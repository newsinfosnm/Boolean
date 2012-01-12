using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;

namespace Boolean.Network.Transmission.SuperSocket
{
    class BufferManager
    {
        private int TotalBytes; 
        public byte[] Buffer;
        private Stack<int> FreeIndexPool;
        private int Index;
        private int BufferSize;

        public BufferManager(int TotalBytes, int BufferSize)
        {
            this.TotalBytes = TotalBytes;
            this.Buffer = new byte[TotalBytes];
            this.FreeIndexPool = new Stack<int>();
            this.BufferSize = BufferSize;
            this.Index = 0;
        }

        public bool SetBuffer(SocketAsyncEventArgs Args)
        {
            if (FreeIndexPool.Count > 0)
            {
                Args.SetBuffer(Buffer, FreeIndexPool.Pop(), BufferSize);
            }
            else
            {
                if ((TotalBytes - BufferSize) < this.Index)
                {
                    return false;
                }

                Args.SetBuffer(Buffer, Index, BufferSize);


                Interlocked.Add(ref Index, BufferSize);
            }

            return true;
        }

        public void FreeBuffer(SocketAsyncEventArgs Args)
        {
            FreeIndexPool.Push(Args.Offset);

            Args.SetBuffer(null, 0, 0);
        }
    }
}
