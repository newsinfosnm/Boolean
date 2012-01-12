using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace Boolean.Network.Transmission.SuperSocket
{
    sealed class SocketAsyncEventArgsPool
    {
        private Stack<SocketAsyncEventArgs> Pool;

        public SocketAsyncEventArgsPool(Int32 Capacity)
        {
            this.Pool = new Stack<SocketAsyncEventArgs>(Capacity);
        }

        public Int32 Count
        {
            get { return this.Pool.Count; }
        }

        public SocketAsyncEventArgs Pop()
        {
            lock (this.Pool)
            {
                return this.Pool.Pop();
            }
        }

        public void Push(SocketAsyncEventArgs item)
        {
            lock (this.Pool)
            {
                this.Pool.Push(item);
            }
        }
    }
}
