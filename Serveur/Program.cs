using System;

using System.Windows.Forms;

namespace Serveur
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ServeurConfiguration());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Serveur: Erreur d'initialisation !" + ex.Message);
            }
        }

                
        }
}
