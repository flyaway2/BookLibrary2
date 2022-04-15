using IGestEmpBiblio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    public class GestEmpImpl :MarshalByRefObject, IEmprunteur
    {
        //********************************************* consulterovrg ****************************************************//
        public List<ouvrage> ConsulterOvrg()
        {
            List<ouvrage> listOvrg = new List<ouvrage>();
            ouvrage ovrg = null;
            int codeBarre;
            string titre, typeOvrg, auteur, img, theme;
            MySqlConnection conn = null;
            try
            {
                conn = Conx.GetDBConnection();
                conn.Open();
                //selection
                String sql = "Select * from ouvrage";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    theme = input.GetString("theme");

                    codeBarre = input.GetInt32("codeBarre");

                    titre = input.GetString("titre");

                    typeOvrg = input.GetString("typeOvrg");

                    auteur = input.GetString("auteur");

                    img = input.GetString("img");

                    ovrg = new ouvrage(codeBarre, titre, typeOvrg, auteur, img, theme);
                
                    listOvrg.Add(ovrg);

                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                if(conn!=null)
                    conn.Close();
            }
            return listOvrg;
        }
        //****************************************************************** ChercherOvrg ********************************//
        public List<ouvrage> chercherOvrg(ouvrage ovrg, String Choix)
        {
            List<ouvrage> ListOvrg = new List<ouvrage>();
            MySqlConnection c = Conx.GetDBConnection();
            try
            {
                c.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (Choix.Equals("titre"))
            {
                if (ovrg.TypeOvrg == null)
                {
                    MySqlCommand cmd = c.CreateCommand();

                    cmd.CommandText = "select * from ouvrage where titre like '%" + ovrg.Titre + "%';";
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        ouvrage ovr = new ouvrage();
                        ovr.CodeBarre = reader.GetInt32(0);
                        ovr.Titre = reader.GetString(1);
                        ovr.TypeOvrg = reader.GetString(2);
                        ovr.Auteur = reader.GetString(3);
                        ovr.Img = reader.GetString(4);
                        ovr.Theme = reader.GetString(5);
                        ListOvrg.Add(ovr);
                    }
                }
                else
                {
                    MySqlCommand cmd = c.CreateCommand();

                    cmd.CommandText = "select * from ouvrage where titre like '%" + ovrg.Titre + "%' and typeOvrg='" + ovrg.TypeOvrg + "';";
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        ouvrage ovr = new ouvrage();
                        ovr.CodeBarre = reader.GetInt32(0);
                        ovr.Titre = reader.GetString(1);
                        ovr.TypeOvrg = reader.GetString(2);
                        ovr.Auteur = reader.GetString(3);
                        ovr.Img = reader.GetString(4);
                        ovr.Theme = reader.GetString(5);
                        ListOvrg.Add(ovr);
                    }
                }
            }
            else if (Choix.Equals("theme"))
            {
                if (ovrg.TypeOvrg == null)
                {
                    MySqlCommand cmd = c.CreateCommand();

                    cmd.CommandText = "select * from ouvrage where theme like '%" + ovrg.Theme + "%';";
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        ouvrage ovr = new ouvrage();
                        ovr.CodeBarre = reader.GetInt32(0);
                        ovr.Titre = reader.GetString(1);
                        ovr.TypeOvrg = reader.GetString(2);
                        ovr.Auteur = reader.GetString(3);
                        ovr.Img = reader.GetString(4);
                        ovr.Theme = reader.GetString(5);
                        ListOvrg.Add(ovr);

                    }
                }
                else
                {
                    MySqlCommand cmd = c.CreateCommand();

                    cmd.CommandText = "select * from ouvrage where theme like '%" + ovrg.Theme + "%' and typeOvrg='" + ovrg.TypeOvrg + "';";
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        ouvrage ovr = new ouvrage();
                        ovr.CodeBarre = reader.GetInt32(0);
                        ovr.Titre = reader.GetString(1);
                        ovr.TypeOvrg = reader.GetString(2);
                        ovr.Auteur = reader.GetString(3);
                        ovr.Img = reader.GetString(4);
                        ovr.Theme = reader.GetString(5);
                        ListOvrg.Add(ovr);
                    }
                }
            }
            else
            {
                if (ovrg.TypeOvrg == null)
                {
                    MySqlCommand cmd = c.CreateCommand();

                    cmd.CommandText = "select * from ouvrage where auteur like '%" + ovrg.Auteur + "%';";
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        ouvrage ovr = new ouvrage();
                        ovr.CodeBarre = reader.GetInt32(0);
                        ovr.Titre = reader.GetString(1);
                        ovr.TypeOvrg = reader.GetString(2);
                        ovr.Auteur = reader.GetString(3);
                        ovr.Img = reader.GetString(4);
                        ovr.Theme = reader.GetString(5);
                        ListOvrg.Add(ovr);
                    }
                }
                else
                {
                    MySqlCommand cmd = c.CreateCommand();

                    cmd.CommandText = "select * from ouvrage where auteur like '%" + ovrg.Auteur + "%' and typeOvrg='" + ovrg.TypeOvrg + "';";
                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        ouvrage ovr = new ouvrage();
                        ovr.CodeBarre = reader.GetInt32(0);
                        ovr.Titre = reader.GetString(1);
                        ovr.TypeOvrg = reader.GetString(2);
                        ovr.Auteur = reader.GetString(3);
                        ovr.Img = reader.GetString(4);
                        ovr.Theme = reader.GetString(5);
                        ListOvrg.Add(ovr);
                    }
                }
            }
            return ListOvrg;

        }
        //*************************************************** inscrireListAtt ********************************************//
        public int InscrireListAtt(int codeBarre, string IDEmpr)
        {

            MySqlConnection conn = null;
            int v = 0;
            int verifier = 0;
            try
            {
                conn = Conx.GetDBConnection();
                conn.Open();

                string select = "Select count(codeBarre) as nbrCodeBarre from listeattente where codeBarre=" + codeBarre;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = select;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    v = input.GetInt32("nbrCodeBarre");
                    Console.WriteLine(v);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            try
            {

                conn = Conx.GetDBConnection();
                conn.Open();
                MySqlCommand cmd;
                if (v == 0)
                {
                    string sql = "insert into listeattente values('" + codeBarre + "','" + IDEmpr + "',1)";
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    verifier = cmd.ExecuteNonQuery();
                }
                else
                {
                    v = v + 1;
                    string sql = "insert into listeattente values('" + codeBarre + "','" + IDEmpr + "','" + v + "')";
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    verifier = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return verifier;
        }

        //***********************************************************************reserver ****************************//
        public String reserver(String id, int codeBarre)
        {
            MySqlConnection c = Conx.GetDBConnection();
            MySqlCommand cmd = c.CreateCommand();
            try
            {
                c.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            cmd.CommandText = "select IDEmpr from listeprive where IDEmpr='" + id + "';";
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                return "vous êtes privé de la réservation";
            }
            else
            {
                c.Close();
                try
                {
                    c.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                cmd = c.CreateCommand();
                cmd.CommandText = "select * from emprunt where codeBarre=" + codeBarre + ";";
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int i = InscrireListAtt(codeBarre, id);
                    if (i == 1)
                    {
                        return "vous avez été ajoutées à la liste d'attente";
                    }
                    else
                    {
                        return "erreur à l'ajout dans la liste d'attente";
                    }


                }
                else
                {
                    c.Close();
                    try
                    {
                        c.Open();
                        String now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        String after1 = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");



                        cmd.CommandText = "insert into emprunt values (@id,@codeBarre,@dateEmp,@dateFinEmp,0);";
                        cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@codeBarre", MySqlDbType.Int32).Value = codeBarre;
                        cmd.Parameters.Add("@dateEmp", MySqlDbType.VarChar).Value = now;
                        cmd.Parameters.Add("@dateFinEmp", MySqlDbType.VarChar).Value = after1;
                       // cmd.Parameters.Add("@confirmer", MySqlDbType.VarChar).Value = 0;
                        cmd.ExecuteNonQuery();
                        c.Close();
                        return "réservation à été faite avec succés";
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    
                }


            }


        }

        //***************************************************ConsulterCompte********************************************//
        public emprunteur ConsulterCompte(String ID)
        {
            MySqlConnection c = Conx.GetDBConnection();
            enseignant ens = new enseignant();
            etudiant etud = new etudiant();
            try
            {
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
              

                cmd.CommandText = "select * from etudiant where numCarte='" + ID + "';";
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    c.Close();
                    c.Open();

                    cmd = c.CreateCommand();
                    cmd.CommandText = "select ID,nom,prenom,pseudo,password,empNconfirme,specialite,niveau,email from etudiant,emprunteur where etudiant.numCarte=emprunteur.ID and numCarte='" + ID + "';";
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        etud.ID1 = reader.GetString(0);
                        etud.Nom = reader.GetString(1);
                        etud.Prenom = reader.GetString(2);
                        etud.Pseudo = reader.GetString(3);
                        etud.Password = reader.GetString(4);
                        etud.EmpNConfirme = reader.GetByte(5);

                        etud.Specialite = reader.GetString(6);
                        etud.Niveau = reader.GetString(7);
                        etud.Email = reader.GetString(8);
                    }
                    c.Close();
                    return etud;

                }
                else
                {
                    c.Close();

                    c.Open();

                    cmd = c.CreateCommand();
                    cmd.CommandText = "select ID,nom,prenom,pseudo,password,empNconfirme,grade,email from enseignant,emprunteur where enseignant.matricule=emprunteur.ID and matricule='" + ID + "';";
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ens.ID1 = reader.GetString(0);
                        ens.Nom = reader.GetString(1);
                        ens.Prenom = reader.GetString(2);
                        ens.Pseudo = reader.GetString(3);
                        ens.Password = reader.GetString(4);
                        ens.EmpNConfirme = reader.GetInt16(5);
                        ens.Grade = reader.GetString(6);
                        ens.Email = reader.GetString(7);

                    }
                    c.Close();
                    return ens;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //******************************************* modifierCompte ***************************************************//
        public void modifierCompteEtud(etudiant etud)
        {
            MySqlConnection c = Conx.GetDBConnection();
            try
            {
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "update etudiant set specialite=@spec,niveau=@niv  where numCarte=@numCarte; update emprunteur set nom=@nom,prenom=@prenom,password=@password,pseudo=@pseudo,email=@email where ID=@ID;";
                cmd.Parameters.Add("@spec", MySqlDbType.VarChar).Value = etud.Specialite;
                cmd.Parameters.Add("@niv", MySqlDbType.VarChar).Value = etud.Niveau;
                cmd.Parameters.Add("@numCarte", MySqlDbType.VarChar).Value = etud.ID1;
                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = etud.ID1;
                cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = etud.Nom;
                cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = etud.Prenom;
                cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = etud.Password;
                cmd.Parameters.Add("@Pseudo", MySqlDbType.VarChar).Value = etud.Pseudo;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = etud.Email;
                cmd.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        //*********************************************** modifierCompte(ensaignant ens)*********************************//
        public void modifierCompteEns(enseignant ens)
        {
            MySqlConnection c = Conx.GetDBConnection();
            try
            {
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "update enseignant set grade=@grade  where matricule=@matricule; update emprunteur set nom=@nom,prenom=@prenom,password=@password,pseudo=@pseudo where ID=@ID";
                cmd.Parameters.Add("@grade", MySqlDbType.VarChar).Value = ens.Grade;
                cmd.Parameters.Add("@matricule", MySqlDbType.VarChar).Value = ens.ID1;
                cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = ens.ID1;
                cmd.Parameters.Add("@nom", MySqlDbType.VarChar).Value = ens.Nom;
                cmd.Parameters.Add("@prenom", MySqlDbType.VarChar).Value = ens.Prenom;
                cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = ens.Password;
                cmd.Parameters.Add("@Pseudo", MySqlDbType.VarChar).Value = ens.Pseudo;
                cmd.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
        //**************************************** authentifierEtud *************************************//
        public string authentifierEtud(String pseudo, String password)
        {
            MySqlConnection c = Conx.GetDBConnection();
            string id = null;
            try
            {
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "select emprunteur.ID from etudiant,emprunteur where etudiant.numCarte=emprunteur.ID and pseudo='" + pseudo + "' and password='" + password + "';";
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetString(0);
                }
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }

            return id;
        }

        //**************************************** authentifierEns ********************************************//
        public string authentifierEns(String pseudo, String password)
        {
            MySqlConnection c = Conx.GetDBConnection();
            string id = null;
            try
            {
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "select * from enseignant,emprunteur where enseignant.matricule=emprunteur.ID and pseudo='" + pseudo + "' and password='" + password + "';";
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetString(0);
                }
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }

            return id;
        }
        //************************************************* listeAttente ***************************************************//
        public List<listeAttente> listeattente(string id)
        {
            List<listeAttente> listeatt = new List<listeAttente>();
            MySqlConnection c = Conx.GetDBConnection();
            try
            {
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "select * from listeattente where IDEmpr='" + id + "';";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listeAttente att = new listeAttente();
                    att.CodeBarre = reader.GetInt32(0);
                    att.IDEmpr1 = reader.GetString(1);
                    att.Priorite = reader.GetInt32(2);
                    listeatt.Add(att);
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            return listeatt;
        }
        //************************************************* listeemprunt ****************************************************//

        public List<emprunt> listeemprunt(string id)
        {
            List<emprunt> listempr = new List<emprunt>();
            try
            {
                MySqlConnection c = Conx.GetDBConnection();
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "select * from emprunt where IDEmpr='" + id + "';";
                Console.WriteLine("id:" + id);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    emprunt emp = new emprunt();
                    emp.IDEmpr1 = reader.GetString(0);
                    Console.WriteLine("  listeemprunt" + emp.IDEmpr1);
                    emp.CodeBarre = reader.GetInt32(1);
                    emp.DateEmp = reader.GetDateTime(2);
                    emp.DateFinEmp = reader.GetDateTime(3);
                    if (reader.GetInt32(4) == 0)
                    {
                        emp.Confirmer = false;
                    }
                    else if (reader.GetInt32(4) == 1)
                    {
                        emp.Confirmer = true;
                    }

                    listempr.Add(emp);
                }
                c.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return listempr;
        }
        //************************************************* attendreConfirmation ******************************************************//
        public int attendreConfirmation(string id)
        {
            int n = 0;
            try
            {
                MySqlConnection c = Conx.GetDBConnection();
                c.Open();
                MySqlCommand cmd = c.CreateCommand();

                cmd.CommandText = "select count(IDEmpr) from emprunt where IDEmpr='" + id + "' and confirmer=0;";
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    n = reader.GetInt32(0);
                    Console.WriteLine(n);

                }
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("erreur: " + e);
            }
            return n;
        }
        //******************************* notifierParEmail **************************//

        public static void notifierParEmail(object source, string email)
        {

            try
            {


                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");

                mail.From = new MailAddress("h.amine.dz@hotmail.fr");
                Console.WriteLine(email);
                mail.To.Add(email);
                mail.Subject = "Emprunt d'ouvrage";
                mail.Body = "nous tenons à vous informé que l'ouvrage que vous avez choisi est disponible, veuillez vous présenter à la bibliothèque pour confirmer votre réservation";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("h.amine.dz@hotmail.fr", "dexter-_-07");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("mail Send");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public bool IsActive()
        {
            return true;
        }

        public int Addup()
        {
            return 1 + 9;
        }

        public emprunteur ListEmprs()
        {
            MySqlConnection conn = null;
            List<emprunteur> emprlist = new List<emprunteur>();
            try
            {
                conn = Conx.GetDBConnection();
                conn.Open();
                //selection
                String sql = "Select * from emprunteur";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader input = cmd.ExecuteReader();
                emprunteur empr = new emprunteur();
                while (input.Read())
                {
                    empr.ID1 = input.GetString(0);
                    empr.Nom = input.GetString(1);
                    empr.Prenom = input.GetString(2);
                    empr.Pseudo = input.GetString(3);
                    empr.Password = input.GetString(4);
                    empr.EmpNConfirme = input.GetByte(5);

                    empr.Email = input.GetString(6);


                    emprlist.Add(empr);

                }
                return empr;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}

