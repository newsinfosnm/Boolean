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

        internal SocketAsyncEventArgsPool(Int32 Capacity)
        {
            this.Pool = new Stack<SocketAsyncEventArgs>(Capacity);
        }

        internal Int32 Count
        {
            get { return this.Pool.Count; }
        }

        internal SocketAsyncEventArgs Pop()
        {
            lock (this.Pool)
            {
                return this.Pool.Pop();
            }
        }

        internal void Push(SocketAsyncEventArgs item)
        {
            lock (this.Pool)
            {
                this.Pool.Push(item);
            }
        }
    }
}
