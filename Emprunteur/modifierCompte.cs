using IGestEmpBiblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class modifierCompte : Form
    {
        IEmprunteur IEmp;
        public modifierCompte(IEmprunteur IEmp)
        {
            this.IEmp = IEmp;
            InitializeComponent();
            enseignant empr=(enseignant)IEmp.ConsulterCompte(LoginInfo.id);
            nomEns.Text = empr.Nom;
            prenomEns.Text = empr.Prenom;
            pseudoEns.Text = empr.Pseudo;
            passwordEns.Text = empr.Password;
            EmailEns.Text = empr.Email;
            gradeEns.Text = empr.Grade;

          
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nomEns.Text) || string.IsNullOrEmpty(prenomEns.Text) || string.IsNullOrEmpty(pseudoEns.Text) || string.IsNullOrEmpty(passwordEns.Text) || string.IsNullOrEmpty(EmailEns.Text) || string.IsNullOrEmpty(gradeEns.Text))
            {
                MessageBox.Show("S.V.P remplir tous les champs");
            }else if (nomEns.BackColor==Color.Red || prenomEns.BackColor==Color.Red ||  EmailEns.BackColor==Color.Red)
            {
                MessageBox.Show("S.V.P remplir tous les champs correctement");
            }
            else
            {
                enseignant ens = new enseignant();
                ens.ID1 = LoginInfo.id;
                ens.Nom = nomEns.Text;
                ens.Prenom = prenomEns.Text;
                ens.Pseudo = pseudoEns.Text;
                ens.Password = passwordEns.Text;
                ens.Email = EmailEns.Text;
                ens.Grade = gradeEns.Text;
                IEmp.modifierCompteEns(ens);

            }
          
        }

        private void enablePassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (enablePassword2.Checked){
                passwordEns.UseSystemPasswordChar = false;
                }else{
                passwordEns.UseSystemPasswordChar = true;
            }
            
        }

        private void prenomEns_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(prenomEns.Text))
            {
                prenomEns.BackColor = Color.White;
            }
            else
            {
                prenomEns.BackColor = Color.Red;
            }
        }

        private void nomEns_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(nomEns.Text))
            {
                nomEns.BackColor = Color.White;
            }
            else
            {
                nomEns.BackColor = Color.Red;
            }
        }

        private void EmailEns_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).IsMatch(EmailEns.Text))
            {
                EmailEns.BackColor = Color.White;
            }
            else
            {
                EmailEns.BackColor = Color.Red;
            }
        }
    }
}
