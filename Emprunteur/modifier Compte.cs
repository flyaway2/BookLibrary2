using IGestEmpBiblio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class modifier_Compte : Form
    {
        IEmprunteur IEmp;
        public modifier_Compte(IEmprunteur IEmp)
        {
            InitializeComponent();
            this.IEmp = IEmp;
            etudiant etud = (etudiant)IEmp.ConsulterCompte(LoginInfo.id);
            nom.Text = etud.Nom;
            prenom.Text = etud.Prenom;
            pseudo.Text = etud.Pseudo;
            password.Text = etud.Password;
            email.Text = etud.Email;
            spec.Text = etud.Specialite;
            niveau.Text = etud.Niveau;

        }

        public delegate void RefreshInfo();
        public  RefreshInfo RefEtudInfo;
        public void OnUpdateInfo()
        {
            RefEtudInfo?.Invoke();
        }


        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nom.Text) || string.IsNullOrEmpty(prenom.Text) || string.IsNullOrEmpty(pseudo.Text) || string.IsNullOrEmpty(password.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(spec.Text) || string.IsNullOrEmpty(niveau.Text))
            {
                MessageBox.Show("S.V.P remplir tous les champs");
            }
            else if (nom.BackColor == Color.Red || prenom.BackColor == Color.Red || email.BackColor == Color.Red )
            {
                MessageBox.Show("S.V.P remplir tous les champs correctement");
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
                etud.Niveau = niveau.Text;
                etud.NumCarte = LoginInfo.id;
                Console.WriteLine("modifercompte");
                try
                {
                    IEmp.modifierCompteEtud(etud);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
          
                //m.maj();
                this.DialogResult = DialogResult.OK;
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

        private void prenom_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(prenom.Text))
            {
                prenom.BackColor = Color.White;
            }
            else
            {
                prenom.BackColor = Color.Red;
            }
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^[A-Za-z]+$")).IsMatch(nom.Text))
            {
                nom.BackColor = Color.White;
            }
            else
            {
                nom.BackColor = Color.Red;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if ((new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")).IsMatch(email.Text))
            {
                email.BackColor = Color.White;
            }
            else
            {
                email.BackColor = Color.Red;
            }
        }

        private void pseudo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
