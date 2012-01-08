using System; 
using System.Net.Sockets; 
using System.Collections.Generic;

namespace Boolean.Network.Transmission.SuperSocket
{
    class AsyncUserToken
    {
        public Socket Socket;
        public byte[] Buffer;
        public bool Redused;

        public AsyncUserToken() : this(null) { }

        public AsyncUserToken(Socket Socket)
        {
            this.Socket = Socket;
            this.Redused = false;
            this.Buffer = new byte[SessionHandler.RECV_BUFFER_SIZE];
        }
    }
}


