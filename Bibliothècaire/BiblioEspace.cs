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

namespace Bibliothècaire
{
    public partial class BiblioEspace : Form
    {
        IBibliothècaire obj;
        
        public BiblioEspace(IBibliothècaire obj)
        {
        
            InitializeComponent();

            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
       */
            this.obj = obj;
            dataGridViewEmprunts.AutoGenerateColumns = false;
            
            dataGridViewEmprunts.DataSource =obj.consulterEmprunt();
        

            dataGridViewEmprunteurs.AutoGenerateColumns = false;
            dataGridViewEnseignant.AutoGenerateColumns = false;
            dataGridViewEnseignant.DataSource = obj.consulterEnseignant();
            dataGridViewEmprunteurs.DataSource = obj.ConsulterEtudiant();

            //************** ouvrage **************//
            annulerRecherche.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            Console.WriteLine(obj.ConsulterOvrg());
            dataGridView1.DataSource = obj.ConsulterOvrg();
            //*************************************//
        }
        /*
        private IBibliothècaire connectionToServer() {
            IBibliothècaire obj2 = null;
            
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);
                obj2 = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
            }
             catch(Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur"+ex);
            }
            return obj2;
        }
        */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void reservation_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rendre_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmerE_Click(object sender, EventArgs e)
        {


        }

        private void emprunter_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
            */
            dataGridViewEmprunts.AutoGenerateColumns = false;


            dataGridViewEmprunts.DataSource = obj.consulterEmprunt();
          
        }

        private void Ouvrages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emprunt emprunt = new Emprunt();
            emprunt.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int rowIndex = dataGridViewEmprunts.CurrentRow.Index;
            DataGridViewRow SelectedRow = dataGridViewEmprunts.Rows[rowIndex];
            string IDEmpr = SelectedRow.Cells[0].Value.ToString();
            int codeBarre = Convert.ToInt32(SelectedRow.Cells[1].Value.ToString());
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
            */
            dataGridViewEmprunts.DataSource = obj.consulterEmprunt();
            Console.WriteLine(obj.consulterEmprunt().ElementAt(0).IDEmpr1);
            MessageBox.Show(obj.Emprunter(IDEmpr, codeBarre));
            dataGridViewEmprunts.DataSource = obj.consulterEmprunt();
            Console.WriteLine(obj.consulterEmprunt().ElementAt(0).IDEmpr1);
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewEmprunteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
            */
            dataGridViewEmprunteurs.AutoGenerateColumns = false;
            dataGridViewEnseignant.AutoGenerateColumns = false;
            dataGridViewEnseignant.DataSource = obj.consulterEnseignant();
            dataGridViewEmprunteurs.DataSource = obj.ConsulterEtudiant();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewEmprunts.CurrentRow.Index;
            MessageBox.Show(""+rowIndex);
            DataGridView dgv = sender as DataGridView;
            
            DataGridViewRow SelectedRow = dataGridViewEmprunteurs.Rows[rowIndex];
            string IDEmpr = SelectedRow.Cells[0].Value.ToString();
            MessageBox.Show("" + IDEmpr);
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
            */
            MessageBox.Show(obj.supprimerCompte(IDEmpr));
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            AjouterCompte emprunt = new AjouterCompte();
            emprunt.ShowDialog();
        }

        private void suppEns_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewEmprunts.CurrentRow.Index;
            MessageBox.Show("" + rowIndex);
            

            DataGridViewRow SelectedRow = dataGridViewEnseignant.Rows[rowIndex];
            string IDEmpr = SelectedRow.Cells[0].Value.ToString();
            MessageBox.Show("" + IDEmpr);
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
           */
            MessageBox.Show(obj.supprimerCompte(IDEmpr));
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;
            int rowIndex = dataGridView1.CurrentRow.Index;
            DataGridViewRow SelectedRow = dataGridView1.Rows[rowIndex];
            codebarreO.Text= SelectedRow.Cells[0].Value.ToString();
            titreO.Text= SelectedRow.Cells[1].Value.ToString(); 
            typeOvrgO.Text= SelectedRow.Cells[2].Value.ToString();
            auteurO.Text= SelectedRow.Cells[3].Value.ToString();
            imgO.Text= SelectedRow.Cells[4].Value.ToString();
            themeO.Text= SelectedRow.Cells[5].Value.ToString();


        }
        
        private void chercher_Click(object sender, EventArgs e)
        {
            ouvrage ovr = new ouvrage();
            ovr.Auteur = "amine";

            Console.WriteLine(string.IsNullOrEmpty(textChercher.Text));
            if (string.IsNullOrEmpty(textChercher.Text) == false)
            {
                annulerRecherche.Enabled = true;
                chercher.Enabled = false;
                String choix = "";
                if (radioAuteur.Checked == true)
                {
                    ovr.Auteur = textChercher.Text;
                    choix = "auteur";
                }
                else if (radioTheme.Checked == true)
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
                }
                else if (typeOvrg.Text.Equals("thèse"))
                {
                    ovr.TypeOvrg = "thèse";
                }
                else if (typeOvrg.Text.Equals("mémoire"))
                {
                    ovr.TypeOvrg = "mémoire";
                }
               /* IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
                */
                dataGridView1.DataSource = obj.chercherOvrg(ovr, choix);
            }

        }

        private void annulerRecherche_Click(object sender, EventArgs e)
        {
           /* IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");*/
            chercher.Enabled = true;
            annulerRecherche.Enabled = false;
            dataGridView1.DataSource = obj.ConsulterOvrg();
        }

        private void reserver_Click(object sender, EventArgs e)
        {
            
        }

        private void textChercher_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeOvrg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioTitre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            int codeBarre = Convert.ToInt32(codebarreO.Text);
            string Titre = titreO.Text;
            String typeOvrg = typeOvrgO.Text;
            string Auteur = auteurO.Text;
            string image = imgO.Text;
            string Theme = themeO.Text;
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
           */
            MessageBox.Show(obj.ModifierOvrg(codeBarre,Titre,typeOvrg,Auteur,image,Theme)); 
        }

        private void AjouterO_Click(object sender, EventArgs e)
        {
            AjouterOuvrage emprunt = new AjouterOuvrage();
            emprunt.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
           */
            //************** ouvrage **************//
            annulerRecherche.Enabled = false;

            dataGridView1.AutoGenerateColumns = false;
            Console.WriteLine(obj.ConsulterOvrg());
            dataGridView1.DataSource = obj.ConsulterOvrg();
            //*************************************//
        }

        private void radioAuteur_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            DataGridViewRow SelectedRow = dataGridView1.Rows[rowIndex];
           int codeBarre= Convert.ToInt32(SelectedRow.Cells[0].Value.ToString());
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
    */       
    MessageBox.Show(obj.supprimerOvrg(codeBarre));

        }

        private void dataGridViewEnseignant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rendre_Click_1(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewEmprunts.CurrentRow.Index;
            DataGridViewRow SelectedRow = dataGridViewEmprunts.Rows[rowIndex];
            string IDEmpr = SelectedRow.Cells[0].Value.ToString();
            int codeBarre = Convert.ToInt32(SelectedRow.Cells[1].Value.ToString());
            /*
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IBibliothècaire obj = (IBibliothècaire)Activator.GetObject(typeof(IBibliothècaire), "tcp://localhost:1069/class1");
    */       
    MessageBox.Show("Email envoyer a l'email: "+obj.rendre(IDEmpr, codeBarre) +" pour qu'il confirme sa reservation à la bibliotheque");
        }
    }
}