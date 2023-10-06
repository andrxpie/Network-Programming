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

namespace SMTP_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Authorize authorize = new();
        Send send;

        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(authorize);
        }

        private void Select_Tab(object sender, SelectionChangedEventArgs e)
        {
            switch (tabs.SelectedIndex)
            {
                case 0: frame.Navigate(authorize); break;
                case 1: send = new Send(authorize.email.Text, authorize.password.Password); frame.Navigate(send); break;
            }
        }
    }
}