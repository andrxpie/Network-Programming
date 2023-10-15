using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Win32;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace SMTP_test
{
    /// <summary>
    /// Interaction logic for Send.xaml
    /// </summary>
    public partial class Send : Page
    {
        string email;
        string password;
        MimeMessage message = new();
        BodyBuilder body = new();
        List<string> attachmentsLocations = new List<string>();

        public Send(string email, string password)
        {
            InitializeComponent();

            this.email = email;
            this.password = password;

        }

        private void SendButton(object sender, RoutedEventArgs e)
        {
            message.From.Add(new MailboxAddress(from.Text, email));
            message.To.Add(new MailboxAddress("Test User", to.Text));
            message.Subject = subject.Text;
            
            message.Importance = (MessageImportance)Enum.Parse(typeof (MessageImportance), (cbox.SelectedItem as ComboBoxItem).Content.ToString());

            body.HtmlBody = tbx.Text;
            message.Body = body.ToMessageBody();

            using(var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                client.Authenticate(email, password);
                client.Send(message);
            }
        }

        private void AddAttachmentButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            body.Attachments.Add(ofd.FileName);

            attachmentsLocations = new();
            foreach (var attachment in body.Attachments)
                attachmentsLocations.Add(attachment.ContentDisposition.FileName);

            attachmentsLBX.ItemsSource = attachmentsLocations;
        }

        private void RemoveAttachmentDClick(object sender, MouseButtonEventArgs e)
        {
            body.Attachments.RemoveAt(attachmentsLBX.SelectedIndex);

            attachmentsLocations = new();
            foreach (var attachment in body.Attachments)
                attachmentsLocations.Add(attachment.ContentDisposition.FileName);

            attachmentsLBX.ItemsSource = attachmentsLocations;
        }
    }
}