using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serveur
{
    public partial class ServeurConfiguration : Form
    {

        public ServerConfig ServerObj { get; set; }
        private ServiceTyp SelectedService;
        public Serveur ServeurObj;
        public ServeurConfiguration()
        {
            InitializeComponent();
            ServerObj = new ServerConfig();
            ServerType.DataSource = Enum.GetValues(typeof(ServiceTyp));
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            if(!IsFiledsEmpty())
            {
                ServiceTyp SelectedType;
                Enum.TryParse<ServiceTyp>(ServerType.SelectedValue.ToString(), out SelectedType);
                try
                {
                    if (SelectedType == ServiceTyp.gRPC)
                    {

                    }
                    else if (SelectedType == ServiceTyp.NetRemoting)
                    {
                        ServeurObj = new NetRemoteServer();
                        ServeurObj.Port = Convert.ToInt32(PortTxt.Text);
                         ServerObj.StartServer((NetRemoteServer)ServeurObj);
                        ServerStateNotifier();
                    }
                    else if (SelectedType == ServiceTyp.WCF)
                    {

                        ServeurObj = new WCFServer();
                        ServeurObj.Port =Convert.ToInt32(PortTxt.Text);
                        ServeurObj.Address = AddressTxt.Text;
                        ServerObj.StartServer((WCFServer)ServeurObj);
                        ServerStateNotifier();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                


            }
            else
            {
                MessageBox.Show("Please type in all the boxes");
            }
            BiblioImpl.Rendu += GestEmpImpl.notifierParEmail;
       
        }

        public void ServerStateNotifier()
        {
            if(ServerObj.IsStarted)
            {
                MsgTxt.Text = "Server Started ...";
                MsgTxt.BackColor = Color.Green;
            }
            else
            {
                MsgTxt.Text = "Server Stopped ...";
                MsgTxt.BackColor = Color.Red;
            }
           
        }

        public bool IsFiledsEmpty()
        {
            if (String.IsNullOrWhiteSpace(PortTxt.Text) || ServerType.SelectedItem == null)
                return true;
            else
                return false;
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
           if(SelectedService==ServiceTyp.WCF)
            {
                ServerObj.StopServer((WCFServer)ServeurObj);
                ServerStateNotifier();
            }
            else if(SelectedService==ServiceTyp.NetRemoting)
            {
                ServerObj.StopServer((NetRemoteServer)ServeurObj);
                ServerStateNotifier();
            }
            
        }

        private void ServerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Enum.TryParse<ServiceTyp>(((ComboBox)sender).SelectedValue.ToString(), out SelectedService);
            if(SelectedService==ServiceTyp.NetRemoting)
            {
                AddressTxt.Enabled = false;
            }else
            {
                AddressTxt.Enabled = true;
            }
        }
    }
    
}
