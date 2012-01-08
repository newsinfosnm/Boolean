using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using Boolean.Habbo.Characters;

namespace Boolean.Network.Transmission
{
    class Session
    {
        public int Id;
        public Socket Socket;
        public SocketAsyncEventArgs Args;
        public Character Character;

        public Session(int Id, Socket Socket, SocketAsyncEventArgs Args)
        {
            this.Id = Id;
            this.Args = Args;
            this.Socket = Socket;
        }

        public void Send(byte[] Bytes)
        {
            try
            {
                Socket.Send(Bytes);
            }
            catch { SessionHandler.CloseClientSocket(Args); }
        }
    }
}
