using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;

namespace DiscardServerLibrary
{
    class Message
    {
        public String data;
        
        public Message(String str)
        {
            data = str;
        }

        public String GetData()
        {
            return data;
        }

        public void SetData(String mes)
        {
            this.data = mes;
        }

        public void Clear()
        {
            data = "";
        }

        public void ReadFromFile(String filename)
        {
            if (File.Exists(filename))
            {
                data = File.ReadAllText(filename);
            }
        }

        public void SaveToFile(String filename)
        {
            if (File.Exists(filename))
            {
                File.WriteAllText(filename, data);
            }
        }
    }

    class DiscardClient
    {
        #region attributes

        protected ProtocolType protocol;
        protected Socket socket;
        protected String address;
        protected int    port;
        protected bool   connected;                        
        
        #endregion

        #region procedures

        #region constructor
        
        public DiscardClient()
        {
            port = 9;

            address = "";

            protocol = ProtocolType.Tcp;

            connected = false;
        }

        public DiscardClient(String address)
        {
            port = 9;

            this.address = address;

            protocol = ProtocolType.Tcp;

            connected = false;
        }

        public DiscardClient(String address, ProtocolType protocol)
        {
            port = 9;
            
            this.address = address;

            this.protocol = protocol;

            connected = false
        }

        public DiscardClient(String address, ProtocolType protocol, bool flagConnect)
        {
            port = 9;
            
            this.address = address;

            this.protocol = protocol;

            if ( flagConnect ) Connect();
        }

        #endregion
               
        #region procedures for set connection
        
        public bool Connect()
        {
            if ( address != null )
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, protocol);

                    socket.Connect(address, port);

                    connected = true;                    
                }
                catch (SocketException ex)
                {
                    socket = null;

                    connected = false;                    
                }
            }

            return connected;
        }
        
        //--процедура подключения к серверу
        public bool Connect(String address)
        {
            this.address = address;

            return Connect();
        }

        public bool Disconnect()
        {
            if (socket != null)
            {
                try
                {
                    socket.Disconnect(false);

                    socket = null;

                    connected = false;                    
                }
                catch (SocketException ex)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsConnected()
        {
            return connected;
        }

        public void SelectProtocol(ProtocolType protocol)
        {
            this.protocol = protocol;
        }

        #endregion 

        #region procedures for send data
        
        public void SendData(String data)
        {
            //byte[] mas = Convert.ToByte(data);
        }

        public void SendData(byte[] data)
        {
            socket.Send( data );
        }

        public void SendFile(String filename)
        {
            if (socket != null & connected)
            
                if ( File.Exists(filename))
            
                    socket.SendFile(filename);
        }
        
        public void SendMessage(Message message) 
        {
            SendData(message.data);
        }

        #endregion
        #endregion
    }
}
