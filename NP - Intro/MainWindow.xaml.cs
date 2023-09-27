using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NP___Intro
{
    public partial class MainWindow : Window
    {
        IPAddress ip { get; set; } = IPAddress.Parse("127.0.0.1");
        int port { get; set; } = 8080;
        IPEndPoint iep { get; set; } // ip end point
        EndPoint rep { get; set; } // remouted end point
        Socket socket { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton(object sender, RoutedEventArgs e)
        {
            try
            {
                // sending
                ip = IPAddress.Parse(ipTbx.Text);
                iep = new IPEndPoint(ip, port);
                rep = new IPEndPoint(IPAddress.Any, 0);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                byte[] data = Encoding.UTF8.GetBytes(messageTbx.Text);

                socket.SendTo(data, iep);
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();

                // recieving
                socket.Bind(iep);

                int bytes = 0;
                data = new byte[1024];
                bytes = socket.ReceiveFrom(data, ref rep);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}