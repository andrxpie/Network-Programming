﻿using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace IMAP
{
    /// <summary>
    /// Interaction logic for Authorize.xaml
    /// </summary>

    public partial class Authorize : Page
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void SubmittButton(object sender, RoutedEventArgs e)
        {
            using(var client = new ImapClient())
            {
                client.Connect();
            }
        }
    }
}