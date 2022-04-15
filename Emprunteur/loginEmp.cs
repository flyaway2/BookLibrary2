
using IGestEmpBiblio;
using Serveur;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class loginEmp : Form
    {
        IEmprunteur IEmp;
        public ServiceTyp SelectedService;
        public ClientConfig ClientConf;
        public WCFClient WCFObj;
        public ClientConfig ClientObj { get; set; }

        public loginEmp(IEmprunteur  IEmp)
        {
            this.IEmp = IEmp;
            InitializeComponent();
            EtudPassword.UseSystemPasswordChar = true;
            EnsPassword.UseSystemPasswordChar = true;

            this.MaximizeBox = false;
            ServiceType.DataSource = Enum.GetValues(typeof(ServiceTyp));
        }
        public loginEmp()
        {
            InitializeComponent();
            ClientObj = new ClientConfig();
            EtudPassword.UseSystemPasswordChar = true;
            EnsPassword.UseSystemPasswordChar = true;
           
            this.MaximizeBox = false;
            ServiceType.DataSource = Enum.GetValues(typeof(ServiceTyp));
            ClientConf = new ClientConfig();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void authentifierEtud_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(EtudPseudo.Text) || string.IsNullOrEmpty(EtudPassword.Text))
            {
                MessageBox.Show("Remplir les champs S.V.P");
            }
            else
            {
                string check = null;
                try
                {
                     check = IEmp.authentifierEtud(EtudPseudo.Text, EtudPassword.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
                if (check !=null)
                {
                    LoginInfo.pseudo = EtudPseudo.Text;
                    LoginInfo.password = EtudPassword.Text;
                    LoginInfo.id = check;
                    LoginInfo.type = "etud";
                    Form1 m1 = new Form1(IEmp);

                    m1.Show();
                    
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("pseudo ou mot de passe erroné");
                }

            }
        }

        private void EtudPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                EtudPassword.UseSystemPasswordChar = false;
            }
            else
            {
                EtudPassword.UseSystemPasswordChar = true;
            }
        }

        private void showpasswordEns_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordEns.Checked)
            {
                EnsPassword.UseSystemPasswordChar = false;

            }
            else
            {
                EnsPassword.UseSystemPasswordChar = true;
            }
        }

        private void authentifierEns_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(EnsPseudo.Text) || string.IsNullOrEmpty(EnsPassword.Text))
            {
                MessageBox.Show("Remplir les champs S.V.P");
            }
            else
            {
                string check = null;
                try
                {
                     check = IEmp.authentifierEns(EnsPseudo.Text, EnsPassword.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                if (check !=null)
                {
                    LoginInfo.pseudo = EnsPseudo.Text;
                    LoginInfo.password = EnsPassword.Text;
                    LoginInfo.id = check;
                    LoginInfo.type = "ens";
                    Form1 m1 = new Form1(IEmp);

                    m1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("pseudo ou mot de passe erroné");
                }
            }
        }

        public bool IsConfigFieldsEmpty()
        {
            if(string.IsNullOrWhiteSpace(PortTxt.Text) || ServiceType.SelectedItem==null || string.IsNullOrWhiteSpace(AddressTxt.Text))
            {
                return true;
            }else
            {

                return false;
            }
        }
        public void GetConxStatus()
        {
          if( ClientConf.IsConnected)
            {
                ConfigMsgTxt.BackColor = Color.Green;
                ConfigMsgTxt.Text = "Client Connected";
            }
            else
            {
                ConfigMsgTxt.BackColor = Color.Red ;
                ConfigMsgTxt.Text = "Client Disconnected";
            }
        }
        private void SaveConfig_Click(object sender, EventArgs e)
        {
            if(!IsConfigFieldsEmpty())
            {
                if(ClientConf!=null && ClientConf.IsConnected==false)
                {
                    if (SelectedService == ServiceTyp.WCF)
                    {
                        try
                        {
                           WCFObj = new WCFClient();
                            WCFObj.Address = AddressTxt.Text;
                            WCFObj.Port = Convert.ToInt32(PortTxt.Text);
                           
                            IEmp = ClientConf.SetConfig(WCFObj);
                            GetConxStatus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                    }
                    else if (SelectedService == ServiceTyp.NetRemoting)
                    {
                        try
                        {
                            NETREMOTEClient NETREMOTEObj = new NETREMOTEClient();
                            NETREMOTEObj.Port = Convert.ToInt32(PortTxt.Text);
                            NETREMOTEObj.Address = AddressTxt.Text;
                            ClientConf = new ClientConfig();
                            IEmp = ClientConf.SetConfig(NETREMOTEObj);
                            GetConxStatus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Already Connected");
                }
               
              
            }
            else
            {
                MessageBox.Show("Please type the required fields");
            }
           
        }

        private void ServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            Enum.TryParse<ServiceTyp>(((ComboBox)sender).SelectedValue.ToString(), out SelectedService);
            
        }

        private void ClientDisconnectBtn_Click(object sender, EventArgs e)
        {
            if(ClientConf!=null && ClientConf.IsConnected)
            {
                ClientConf.DisconnectFromServer(WCFObj);
                GetConxStatus();
            }
            
        }
    }
}
