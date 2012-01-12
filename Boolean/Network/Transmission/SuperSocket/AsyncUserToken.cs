using System; 
using System.Net.Sockets; 
using System.Collections.Generic;

namespace Boolean.Network.Transmission.SuperSocket
{
    class AsyncUserToken
    {
        public Socket Socket;
        public bool Redused;

        public AsyncUserToken() : this(null) { }

        public AsyncUserToken(Socket Socket)
        {
            this.Socket = Socket;
            this.Redused = false;
        }
    }
}


