using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
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
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace http
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WebClient client;

        public MainWindow()
        {
            InitializeComponent();

            client = new();
        }

        private void DownloadButton(object sender, RoutedEventArgs e)
        {
            if(client.IsBusy)
            {
                MessageBox.Show("Client is busy");
                return;
            }

            string urlAddress = $"https://source.unsplash.com/random/{widthTbx.Text}x{heightTbx.Text}/?animals";
            DownloadFileAsync(urlAddress);
        }

        private async void DownloadFileAsync(string address)
        {
            CommonOpenFileDialog openFileDialog = new CommonOpenFileDialog() { IsFolderPicker = true };            

            if(openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string fileName = new Random().Next(1, 2412).ToString() + ".png";
                string destination = System.IO.Path.Combine(openFileDialog.FileName, fileName);
                await client.DownloadFileTaskAsync(address, destination);
            }
        }
    }
}
