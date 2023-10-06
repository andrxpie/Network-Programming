using MailKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
﻿using MailKit.Net.Smtp;
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
using MimeKit;

namespace SMTP_test
{
    /// <summary>
    /// Interaction logic for Authorize.xaml
    /// </summary>
    public partial class Authorize : Page
    {
        string userEmail = string.Empty;
        string userPassword = string.Empty;
        public bool IsAuthenticated = false;

        public Authorize()
        {
            InitializeComponent();
        }

        private void SubmitButton(object sender, RoutedEventArgs e)
        {
            SmtpClient client = new SmtpClient();

            userEmail = email.Text;
            userPassword = password.Password;

            client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);

            client.Authenticate(userEmail, userPassword);

            IsAuthenticated = true;
            MessageBox.Show("Success!");
        }
    }
}
