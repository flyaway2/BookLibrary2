using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IGestEmpBiblio;
using Serveur;
namespace Bibliothècaire
{
    public partial class login : Form
    {
        public IEmprunteur obj2;
        public IBibliothècaire obj;
        public login()
        {
           InitializeComponent();
            TcpChannel can = new TcpChannel();
            ChannelServices.RegisterChannel(can, false);
             obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
             obj2 = (IEmprunteur)Activator.GetObject(typeof(IEmprunteur), "tcp://localhost:1069/class2");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, CancelEventArgs e)
        {
            if (pseudoo.Text == "")
            {
                e.Cancel = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            if ((pseudoo.Text == "") || (password.Text == ""))
            {
                pseudoo.Text = "";
                password.Text = "";
                MessageBox.Show("Remplir les chemps S.V.P");
            }
            try
            {
              
                // obj.Rendu += obj2.notifierParEmail;

                Boolean verifier = obj.authentificationBiblio(pseudoo.Text, password.Text);
                if (verifier)
                {
                    MessageBox.Show("connexion succesful");
                    BiblioEspace biblioespace = new BiblioEspace(obj);

                    biblioespace.ShowDialog();
                }
                else
                {
                    MessageBox.Show("connexion failed");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pseudoo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
