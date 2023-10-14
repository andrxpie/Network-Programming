using System.Net.Sockets;
using System.Net;
using System.Text;

namespace server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            IPEndPoint remoteEndPoint = null;
            UdpClient listener = new UdpClient(ipPoint);
                
            try
            {
                Console.WriteLine("Server started! Waiting for connection...");

                while (true)
                {
                    byte[] data = listener.Receive(ref remoteEndPoint);

                    string msg = Encoding.Unicode.GetString(data);
                    Console.WriteLine($"{DateTime.Now.ToShortTimeString()}: {msg} from {remoteEndPoint}");

                    string message = msg + " | " + DateTime.Now.ToShortTimeString();
                    data = Encoding.Unicode.GetBytes(message);
                    listener.Send(data, data.Length, remoteEndPoint);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            listener.Close();
        }
    }
}