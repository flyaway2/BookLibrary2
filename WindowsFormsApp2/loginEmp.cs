using IGestEmpBiblio;
using Serveur;
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

namespace WindowsFormsApp2
{
    public partial class loginEmp : Form
    {
        IEmprunteur IEmp;
        IBibliothècaire biblio;
        public loginEmp(IEmprunteur  IEmp)
        {
            this.IEmp = IEmp;
            InitializeComponent();
            EtudPassword.UseSystemPasswordChar = true;
            EnsPassword.UseSystemPasswordChar = true;

            this.MaximizeBox = false;
        }
        public loginEmp()
        {
            InitializeComponent();
            EtudPassword.UseSystemPasswordChar = true;
            EnsPassword.UseSystemPasswordChar = true;
           
            this.MaximizeBox = false;
          

            TcpChannel ch1 = new TcpChannel();
            ChannelServices.RegisterChannel(ch1, false);
            IEmp = (IEmprunteur)Activator.GetObject(typeof(IEmprunteur), "tcp://localhost:3000/emp");
            biblio= (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:3000/biblio");
            biblio.Rendu += IEmp.notifierParEmail;
    

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
                string check = IEmp.authentifierEtud(EtudPseudo.Text, EtudPassword.Text);
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
                string check = IEmp.authentifierEns(EnsPseudo.Text, EnsPassword.Text);
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
    }
}
