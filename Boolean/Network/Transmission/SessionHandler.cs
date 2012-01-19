using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Sockets;
using System.Net;
using System.Threading;

using Boolean.Network.Transmission.SuperSocket;
using Boolean.Network.Transmission;
using Boolean.Enumerables;

namespace Boolean
{
    /// <summary>
    /// SocketListener class using Super-Async.
    /// </summary>
    static class SessionHandler
    {
        #region Fields
        public const int RECV_BUFFER_SIZE = 512;
        public const int OPS_TO_PRE_ALLOC = 2;

        private static SocketAsyncEventArgsPool SocketPool;
        private static Socket BaseSocket;
        private static Semaphore SocketSemaphore;
        private static Dictionary<int, Session> Sessions;
        private static BufferManager BufferManager;

        private static int ConnectedAmount;
        private static int Counter;
        #endregion

        #region Methods
        public static Session GetSession(Socket Socket)
        {
            foreach (var kvp in Sessions)
            {
                if (kvp.Value.Socket == Socket)
                {
                    return kvp.Value;
                }
            }

            return null;
        }

        public static Session GetSessionByCharacterId(int Id)
        {
            foreach (var kvp in Sessions)
            {
                if (kvp.Value.Character != null)
                {
                    if (kvp.Value.Character.Id == Id)
                    {
                        return kvp.Value;
                    }
                }
            }

            return null;
        }

        public static SerializeResult Serialize()
        {
            try
            {
                var MaxConnections = int.Parse(Settings.GetValue("TCP.Listener.Max"));

                Counter = 0;
                Sessions = new Dictionary<int, Session>();
                SocketPool = new SocketAsyncEventArgsPool(MaxConnections);
                ConnectedAmount = new int();
                SocketSemaphore = new Semaphore(MaxConnections, MaxConnections);
                BufferManager = new BufferManager(RECV_BUFFER_SIZE * MaxConnections * OPS_TO_PRE_ALLOC, RECV_BUFFER_SIZE);

                Solution.AppendLine("SessionHandler: Pushing SocketAsync({0}), big-buffer({1})", MaxConnections, BufferManager.Buffer.Length);

                for (int i = 0; i < MaxConnections; i++)
                {
                    var Async = new SocketAsyncEventArgs();
                    Async.Completed += new EventHandler<SocketAsyncEventArgs>(Async_Completed);
                    Async.UserToken = new AsyncUserToken();
                    BufferManager.SetBuffer(Async);

                    SocketPool.Push(Async);
                }

                var IPEndPoint = new IPEndPoint(IPAddress.Parse(Settings.GetValue("TCP.Listener.IP")), int.Parse(Settings.GetValue("TCP.Listener.Port")));

                BaseSocket = new Socket(IPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                BaseSocket.Bind(IPEndPoint);
                BaseSocket.Listen(int.Parse(Settings.GetValue("TCP.Listener.Backlog")));

                WaitForAsync(null);
            }
            catch { return SerializeResult.Broken; }

            return SerializeResult.Finished;
        }
        #endregion

        #region Accepting
        private static void WaitForAsync(SocketAsyncEventArgs Args)
        {
            if (Args == null)
            {
                Args = new SocketAsyncEventArgs();
                Args.Completed += new EventHandler<SocketAsyncEventArgs>(AcceptAsync_Completed);
            }
            else
            {
                Args.AcceptSocket = null;
            }

            SocketSemaphore.WaitOne();

            BaseSocket.AcceptAsync(Args);
        }

        private static void HandleAsync(SocketAsyncEventArgs Args)
        {
            try
            {
                Interlocked.Increment(ref ConnectedAmount);

                var SingleSocketAsync = SocketPool.Pop();
                var Token = (AsyncUserToken)SingleSocketAsync.UserToken;

                Token.Socket = Args.AcceptSocket;

                var Session = new Session(Interlocked.Increment(ref Counter), Token.Socket, Args);

                Sessions.Add(Session.Id, Session);

                if (!Args.AcceptSocket.ReceiveAsync(SingleSocketAsync))
                {
                    HandleReceive(SingleSocketAsync);
                }
            }
            catch { }
            finally { WaitForAsync(Args); }
        }
        #endregion

        #region Traffic
        private static void HandleReceive(SocketAsyncEventArgs Args)
        {
            var Token = Args.UserToken as AsyncUserToken;

            try
            {
                if (Args.BytesTransferred > 0 && Args.SocketError == SocketError.Success)
                {
                    var Received = new byte[Args.BytesTransferred];

                    Array.Copy(BufferManager.Buffer,Args.Offset, Received,0, Args.BytesTransferred);

                    MessageHandler.HandleBytes(GetSession(Token.Socket), ref Received);
                }
                else
                {
                    CloseClientSocket(Args);
                }
            }
            catch { CloseClientSocket(Args); }
            finally { try { Token.Socket.ReceiveAsync(Args); } catch { } }
        }

        private static void HandleSend(SocketAsyncEventArgs Args)
        {
            if (Args.SocketError != SocketError.Success)
            {
                CloseClientSocket(Args);
            }
        }
        #endregion

        #region Extra
        public static void CloseClientSocket(SocketAsyncEventArgs Args)
        {
            var Token = Args.UserToken as AsyncUserToken;

            if (Token.Redused)
            {
                return;
            }

            Token.Redused = true;

            try
            {
                Sessions.Remove(GetSession(Token.Socket).Id);
            }
            catch { }

            try
            {
                Token.Socket.Shutdown(SocketShutdown.Both);
            }
            catch (Exception) { }

            Token.Socket.Close();

            Interlocked.Decrement(ref ConnectedAmount);

            SocketSemaphore.Release();

            SocketPool.Push(Args);
        }

        private static void AcceptAsync_Completed(object sender, SocketAsyncEventArgs Args)
        {
            HandleAsync(Args);
        }

        private static void Async_Completed(object sender, SocketAsyncEventArgs Args)
        {
            if (Args.LastOperation == SocketAsyncOperation.Receive)
            {
                HandleReceive(Args);
            }
            else if (Args.LastOperation == SocketAsyncOperation.Send)
            {
                HandleSend(Args);
            }
        }
        #endregion
    }
}
