using Grpc.Core;
using GrpcService;
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

namespace GrpcServeur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ServerConfiguration : Window
    {
        private Server server;
        private int PortNumber;
        private bool IsServerStarted;
        public ServerConfiguration()
        {
            InitializeComponent();
             
          
        }

        public bool IsUserInputIn()
        {
            bool IsUserInputAvailable = !string.IsNullOrWhiteSpace(AddressTxt.Text) && !string.IsNullOrWhiteSpace(PortTxt.Text);
           return IsUserInputAvailable;
        }

        private void StartServerBtn(object sender, RoutedEventArgs e)
        {
            if(IsUserInputIn())
            {
                
                if(int.TryParse(PortTxt.Text,out PortNumber))
                {
                    try
                    {
                        ServerPort serverPortM = new ServerPort(AddressTxt.Text, Convert.ToInt16(PortTxt.Text), ServerCredentials.Insecure);
                        server = new Server
                        {
                            Services = { Greeter.BindService(new GreeterImpl()) },
                            Ports = { serverPortM }
                        };
                        server.Start();
                        ServerStatus.Content = "Server Started";
                        IsServerStarted = true;
                        ServerStatus.Background = Brushes.ForestGreen;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                }else
                {
                    MessageBox.Show("Please provide a valid port");
                }
              
            }else
            {
                MessageBox.Show("Please type all the required fields");
            }
            
        }

        private void StopServerBtn(object sender, RoutedEventArgs e)
        {
            if(IsServerStarted)
            {
                server.ShutdownAsync().Wait();
                ServerStatus.Content = "Server Shutdown";
                ServerStatus.Background = Brushes.DarkRed;
                IsServerStarted = false;
            }
            
        }
    }
}
