using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Net.Sockets;


namespace DiscardServerLibrary
{
    public class DiscardServer
    {
        protected Socket serverSocket;
        protected String address;
        protected int port;
        protected String data;
        protected ArrayList clients;
        
        public DiscardServer() 
        {
            port = 9;

            clients = new ArrayList();                      

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public DiscardServer(String address) { }
        public DiscardServer(String address, bool flagConnect) { }
    }
}
