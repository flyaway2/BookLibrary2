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
    public partial class modifier_Compte : Form
    {
        IEmprunteur IEmp;
        Form1 m;
        public modifier_Compte(IEmprunteur IEmp,Form1 m)
        {
            this.m = m;
            InitializeComponent();
            this.IEmp = IEmp;
            etudiant etud = (etudiant)IEmp.ConsulterCompte(LoginInfo.id);
            nom.Text = etud.Nom;
            prenom.Text = etud.Prenom;
            pseudo.Text = etud.Pseudo;
            password.Text = etud.Password;
            email.Text = etud.Email;
            spec.Text = etud.Specialite;
            niv.Text = etud.Niveau;

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nom.Text) || string.IsNullOrEmpty(prenom.Text) || string.IsNullOrEmpty(pseudo.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(spec.Text) || string.IsNullOrEmpty(niv.Text))
            {
                MessageBox.Show("S.V.P remplir tous les champs");
            }
            else
            {
                etudiant etud = new etudiant();
                
                etud.ID1 = LoginInfo.id;
                etud.Nom = nom.Text;
                etud.Prenom = prenom.Text;
                etud.Pseudo = pseudo.Text;
                etud.Password = password.Text;
                etud.Email = email.Text;
                etud.Specialite = spec.Text;
                etud.Niveau = niv.Text;
                Console.WriteLine("modifercompte");
                IEmp.modifierCompte(etud);
                m.maj();
                this.Close();
               


            }
        }

        private void enablePassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (enablePassword2.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
