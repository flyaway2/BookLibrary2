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
    public partial class Emprunt : Form
    {
        public Emprunt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void emprunter_Click(object sender, EventArgs e)
        {
            string IDEmpr = idempr.Text;
            int codeBarre = Convert.ToInt32(code_Barre.Text);
            try
            {
                TcpChannel can = new TcpChannel();
                ChannelServices.RegisterChannel(can, false);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur dans le serveur" + ex);
            }

            IEmprunteur obj = (IEmprunteur)Activator.GetObject(typeof(IEmprunteur), "tcp://localhost:1069/class2");
            MessageBox.Show(obj.reserver(IDEmpr, codeBarre));
           
        }
    }
}
