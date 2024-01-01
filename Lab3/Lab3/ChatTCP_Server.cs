using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Lab3
{
    internal class ChatTCP_Server
    {
        public TcpListener server;
        public bool checkConnect;
        public IPAddress ip;
        public int port;
        public IPEndPoint iPEndPoint;
        private static int sizeBuffe = 1024 * 32;
        public ChatTCP_Server(IPAddress IP, int Port)
        {
            this.ip = IP;
            this.port = Port;
            this.checkConnect = false;
            this.iPEndPoint = new IPEndPoint(ip, Port);
            server = new TcpListener(iPEndPoint);


        }
        public static string receive(NetworkStream stream)
        {
            byte[] buffer = new byte[sizeBuffe];            
           stream.Read(buffer, 0, buffer.Length);
           return Encoding.UTF8.GetString(buffer);
        }
        public static void send(string data,NetworkStream stream) {
            byte[] buffer = new byte[sizeBuffe];
            buffer = Encoding.UTF8.GetBytes(data);
            stream.Write(buffer, 0, buffer.Length);
        }
    }
}
