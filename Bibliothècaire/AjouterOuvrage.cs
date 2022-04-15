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
    public partial class AjouterOuvrage : Form
    {
        public AjouterOuvrage()
        {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            int codeBarre = Convert.ToInt32(codeO.Text);
            string Titre = titre.Text;
            String typeOvrg = typeO.Text;
            string Auteur = auteur.Text;
            string image = img.Text;
            string Theme = theme.Text;
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
            MessageBox.Show(obj.AjouterOvrg(codeBarre, Titre, typeOvrg, Auteur, image, Theme));
        }
    }
}
