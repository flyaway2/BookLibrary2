using IGestEmpBiblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                IEmp.modifierCompte(ens);

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
    }
}
