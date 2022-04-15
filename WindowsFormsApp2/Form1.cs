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
using Serveur;
using IGestEmpBiblio;
using System.Collections;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        IEmprunteur IEmp;
        public Form1(IEmprunteur IEmp)
        {
            InitializeComponent();
            this.IEmp = IEmp;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = IEmp.ConsulterOvrg();
            
            
            listeattente.DataSource = IEmp.listeattente(LoginInfo.id);
            List<listeAttente> test=IEmp.listeattente(LoginInfo.id);
            Console.WriteLine("IDEmpr"+ test.ElementAt(0).IDEmpr1);
            empruntlist.AutoGenerateColumns = false;
            empruntlist.DataSource = IEmp.listeemprunt(LoginInfo.id);
            annulerRecherche.Enabled = false;
            grade.Hide();
            spec.Hide();
            niv.Hide();
            gradelabel.Hide();
            speclabel.Hide();
            nivlabel.Hide();
           
            attConf.Text = IEmp.attendreConfirmation(LoginInfo.id).ToString();

            Nemp.Text = IEmp.listeemprunt(LoginInfo.id).Count.ToString();
            listAtt.Text = IEmp.listeattente(LoginInfo.id).Count.ToString();
            empNconfirme.Text = IEmp.ConsulterCompte(LoginInfo.id).EmpNConfirme.ToString();
            if (LoginInfo.type.Equals("ens"))
            {
                grade.Show();
                gradelabel.Show();
                enseignant ens= (enseignant)IEmp.ConsulterCompte(LoginInfo.id);
                Nom.Text = ens.Nom;
                prenom.Text = ens.Prenom;
                pseudo.Text = ens.Pseudo;
                email.Text = ens.Email;
                password.Text = ens.Password;
                grade.Text = ens.Grade;

            }
            else
            {
                spec.Show();
                speclabel.Show();
                niv.Show();
                nivlabel.Show();
                etudiant etud=(etudiant)IEmp.ConsulterCompte(LoginInfo.id);
                Nom.Text = etud.Nom;
                prenom.Text = etud.Prenom;
                pseudo.Text = etud.Pseudo;
                email.Text = etud.Email;
                password.Text = etud.Password;
                spec.Text = etud.Specialite;
                niv.Text = etud.Niveau;
            }
            
            
        }
        public void maj()
        {
            if (LoginInfo.type.Equals("ens"))
            {
                enseignant ens = (enseignant)IEmp.ConsulterCompte(LoginInfo.id);
                Nom.Text = ens.Nom;
                prenom.Text = ens.Prenom;
                pseudo.Text = ens.Pseudo;
                email.Text = ens.Email;
                password.Text = ens.Password;
                grade.Text = ens.Grade;

            }
            else
            {
               
                etudiant etud = (etudiant)IEmp.ConsulterCompte(LoginInfo.id);
                Nom.Text = etud.Nom;
                prenom.Text = etud.Prenom;
                pseudo.Text = etud.Pseudo;
                email.Text = etud.Email;
                password.Text = etud.Password;
                spec.Text = etud.Specialite;
                niv.Text = etud.Niveau;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            emprunt em = new emprunt();
            Console.WriteLine(dataGridView1.SelectedCells.Count);
            if (dataGridView1.SelectedCells.Count ==6)
            {
                Console.WriteLine(dataGridView1.SelectedCells[0].OwningColumn.HeaderText);
                if (dataGridView1.SelectedCells[0].OwningColumn.HeaderText.Equals("codeBarre"))
                {
                    int codeBarre = Int32.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                    
                    String msg=IEmp.reserver(LoginInfo.id,codeBarre);
                    MessageBox.Show(msg);
                }
               
                

            }
           

        }
        private void toustab(object sender,EventArgs e)
        {
            empruntlist.DataSource = IEmp.listeemprunt(LoginInfo.id);
            dataGridView1.DataSource = IEmp.ConsulterOvrg();
            listeattente.DataSource = IEmp.listeattente(LoginInfo.id);
            attConf.Text = IEmp.attendreConfirmation(LoginInfo.id).ToString();

            Nemp.Text = IEmp.listeemprunt(LoginInfo.id).Count.ToString();
            listAtt.Text = IEmp.listeattente(LoginInfo.id).Count.ToString();
            empNconfirme.Text = IEmp.ConsulterCompte(LoginInfo.id).EmpNConfirme.ToString();
        }
        private void textChercher_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeOvrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chercher_Click(object sender, EventArgs e)
        {
            ouvrage ovr = new ouvrage();
            ovr.Auteur = "amine";
            
            Console.WriteLine(string.IsNullOrEmpty(textChercher.Text));
            if (string.IsNullOrEmpty(textChercher.Text)==false)
            {
                annulerRecherche.Enabled = true;
                chercher.Enabled = false;
                String choix = "";
                if (radioAuteur.Checked == true)
                {
                    ovr.Auteur = textChercher.Text;
                    choix = "auteur";
                }else if (radioTheme.Checked == true)
                {
                    ovr.Theme = textChercher.Text;
                    choix = "theme";
                }
                else
                {
                    ovr.Titre = textChercher.Text;
                    choix = "titre";
                }
                if (typeOvrg.Text.Equals("livre"))
                {
                    ovr.TypeOvrg = "livre";
                }else if (typeOvrg.Text.Equals("thèse"))
                {
                    ovr.TypeOvrg = "thèse";
                }else if (typeOvrg.Text.Equals("mémoire"))
                {
                    ovr.TypeOvrg = "mémoire";
                }
                dataGridView1.DataSource= IEmp.chercherOvrg(ovr, choix);
            }
          
          
        }

        private void annulerRecherche_Click(object sender, EventArgs e)
        {
            chercher.Enabled = true;
            annulerRecherche.Enabled = false;
            dataGridView1.DataSource = IEmp.ConsulterOvrg();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
       
        private void modifierCompte_Click(object sender, EventArgs e)
        {
            if(LoginInfo.type.Equals("etud"))
            {
                modifier_Compte mc = new modifier_Compte(IEmp,this);
                mc.Show();
            }
            else
            {
                modifierCompte mc = new modifierCompte(IEmp);
                mc.Show();
            }
        }

        private void passwordEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordEnable.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void image_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                String path = selectedRow.Cells[4].Value.ToString();
                image.Image = Image.FromFile(@selectedRow.Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private void déconnexion_Click(object sender, EventArgs e)
        {
            loginEmp login = new loginEmp(IEmp);
            this.Hide();
            login.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
