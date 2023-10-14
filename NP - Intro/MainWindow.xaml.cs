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
        IPAddress ip;
        int port;

        IPEndPoint iep;
        IPEndPoint rip = null;
        UdpClient client = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SendButton(object sender, RoutedEventArgs e)
        {
            try
            {
                ip = IPAddress.Parse(ipTbx.Text);
                port = int.Parse(portTbx.Text);
                iep = new IPEndPoint(ip, port);

                byte[] data = Encoding.Unicode.GetBytes(messageTbx.Text);
                client.Send(data, data.Length, iep);

                data = client.Receive(ref rip);
                string response = Encoding.Unicode.GetString(data);

                history.Items.Add(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}