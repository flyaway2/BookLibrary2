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
    public partial class AjouterCompte : Form
    {
        public AjouterCompte()
        {
            InitializeComponent();
        }

        private void typeEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)typeEmp.SelectedItem == "etudiant")
            {
                labelgrade.Visible = false;
                grade.Visible = false;
                labelspec.Visible = true;
                specialite.Visible = true;
                labelniveau.Visible = true;
                niveau.Visible = true;
            }
            else if((string)typeEmp.SelectedItem == "enseignant")
            {
                labelspec.Visible = false;
                specialite.Visible = false;
                labelniveau.Visible = false;
                niveau.Visible = false;
                labelgrade.Visible = true;
                grade.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = codeEmp.Text;
            string TypeEmp = typeEmp.Text;
            string nom = nomE.Text;
            string prenom = prenomE.Text;
            string Email = email.Text;
            string pass = password.Text;
            string Pseudo = pseudo.Text;
            string Spec ="", Niveau ="", Grade ="";
            if (TypeEmp == "etudiant")
            {
                Spec = specialite.Text;
                Niveau = niveau.Text;
            }
            else if (TypeEmp == "enseignant")
            {
                Grade = grade.Text;
            }
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
            MessageBox.Show(obj.AjouterCompte(ID, nom, prenom, Pseudo, pass, Email, Spec, Niveau, Grade, TypeEmp));
        }
    }
}
