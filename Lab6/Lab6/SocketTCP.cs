using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class SocketTCP
    {
        public static string Receive(NetworkStream stream)
        {
            try
            {
                byte[] buffer = new byte[256];
                stream.Read(buffer, 0, buffer.Length);
                return RSA.DecryptData(buffer);
            }
            catch
            {
                return null;
            }
        }
        public static void Send(NetworkStream stream, string data)
        {
            try
            {
                byte[] buffer = new byte[256];
                buffer = RSA.EncryptData(data);
                stream.Write(buffer, 0, buffer.Length);
            }
            catch { return; }
        }
    }
}
