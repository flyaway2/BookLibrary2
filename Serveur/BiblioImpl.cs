using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGestEmpBiblio;
using System.Runtime.Remoting;
using MySql.Data.MySqlClient;
using System.Collections;
namespace Serveur
{

    public class BiblioImpl : MarshalByRefObject, IGestEmpBiblio.IBibliothècaire
    {
       public BiblioImpl()
        {

        }
        // --------------------------les methodes de connnections a la BD Mysql------------------------------------
        public static MySqlConnection
                 GetDBConnection(string host, int port, string database, string username, string password)
        {
            // Connection String.
            String connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }

        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "bibliodb";
            string username = "root";
            string password = "dexter-_-07";

            return GetDBConnection(host, port, database, username, password);
        }
        // --------------------------Fin les methodes de connnections a la BD Mysql------------------------------------

        //-----------------------ConsulterOvrg-------------------------
        public List<ouvrage> ConsulterOvrg()
        {
            List<ouvrage> listOvrg = new List<ouvrage>();
            ouvrage ovrg = null;
            int codeBarre;
            string titre, typeOvrg, auteur, img, theme;
            MySqlConnection conn = null;
            try
            {
                conn = GetDBConnection();
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
                    if (ovrg == null)
                    {
                        Console.WriteLine("orvg null");
                    }

                    listOvrg.Add(ovrg);


                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listOvrg;
        }
        //---------------------------AjouterCompte------------------------------------------
        public string AjouterCompte(string iD, string nom, string prenom, string pseudo, string password, string email, string spec, string niveau, string grade, string typeEmp)
        {
            MySqlConnection conn = null;
        
            Boolean exister = false;
            try
            {
                conn = GetDBConnection();
                conn.Open();
                string select = "Select ID from emprunteur where ID='" + iD + "'";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = select;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    string ID = input.GetString("ID");
                    if (ID != null)
                    {

                        exister = true;
                    }
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

            if (exister)
            {
                return "Emprunteur existe deja";
            }
            int countRow1 = 0, countRow2 = 0;
            try
            {
                conn = GetDBConnection();
                conn.Open();
                string sql = "insert into emprunteur values('" + iD + "','" + nom + "','" + prenom + "','" + pseudo + "','" + password + "',0,'" + email + "')";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                countRow1 = cmd.ExecuteNonQuery();
                conn.Close();
                if (typeEmp.Equals("etudiant"))
                   
                {
                    conn.Open();
                    Console.WriteLine("spec"+spec);
                    string sqlEtud = "insert into etudiant values('" + iD + "','" + spec + "','" + niveau + "')";
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sqlEtud;
                    countRow2 = cmd.ExecuteNonQuery();
                }
                else
                {
                    conn.Open();
                    ; string sqlEns = "insert into enseignant values('" + iD + "','" + grade + "')";
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sqlEns;
                    countRow2 = cmd.ExecuteNonQuery();
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
            if ((countRow1 == 1) && (countRow2 == 1))
            {
                return "compte ajouter avec succes";
            }
            else
            {
                return "probleme avec l'insertion des tuples";

            }

        }





        public string Emprunter(string IDEmpr, int codeBarre)
        {

            MySqlConnection conn = null;
            //IEmprunteur e=new EmprunteurImpl();
           
            int verifier = 0;
            string IDempr;
            int codebarre;
            DateTime dateEmp = DateTime.Now;
            string datetime = "";
            try
            {

                conn = GetDBConnection();
                conn.Open();
                string select = "Select  IDEmpr,codeBarre,dateEmp from emprunt where codeBarre=" + codeBarre + " and IDEmpr='" + IDEmpr + "'";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = select;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {

                    IDempr = input.GetString("IDEmpr");
                    codebarre = input.GetInt32("codeBarre");
                    dateEmp = input.GetDateTime("dateEmp");
                    Console.WriteLine(dateEmp);

                    if (IDempr != null)
                    {
                        /*
                            TimeSpan Diff = DateTime.Now - dateEmp;
                            Console.WriteLine((int)Diff.TotalHours);
                            if ((int)Diff.TotalHours >= 24)
                            {
                                return "la réservation a depasser les 24h";
                            }
                            */
                    }
                    else
                    {

                     //   Console.WriteLine(e.reserver(IDempr,codebarre));
                    }

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
                conn = GetDBConnection();
                conn.Open();
                string sql = "select dateEmp from emprunt where codeBarre=" + codeBarre + " and IDEmpr='" + IDEmpr + "'";
                //string date = "SELECT TIMESTAMPADD(day,15,'" + + "')";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {

                    dateEmp = input.GetDateTime("dateEmp");
                    datetime = dateEmp.ToString("yyyy-MM-dd hh:mm:ss");


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
                conn = GetDBConnection();
                conn.Open();
                //string date = "SELECT TIMESTAMPADD(day,15,'"+dateEmp+"')";
                string sql = "update emprunt set dateFinEmp=(SELECT TIMESTAMPADD(day,15,'" + datetime + "')),confirmer=" + 1 + " where codeBarre=" + codeBarre + " and IDEmpr='" + IDEmpr + "'";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                verifier = cmd.ExecuteNonQuery();

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
            if (verifier == 0)
            {
                return "probléme dans la méthode";
            }
            else
            {
                return "confirmation de résezrvation avec succes";
            }
        }


        public string PriveDuService(string IDEmpr)
        {
            MySqlConnection conn = null;
          
     
            List<String> ListIDEmp = new List<string>();
       
            try
            {
                conn = GetDBConnection();
                conn.Open();
                string select = "select ID from emprunteur where empNconfirme>=3";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = select;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    ListIDEmp.Add(input.GetString("ID"));
                    if (ListIDEmp.ElementAt(0) == null)
                    {
                        return "Pas d'emprunteurs qui ont fait trois réservations non confirmées";
                    }
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
                conn = GetDBConnection();
                conn.Open();
                MySqlCommand cmd;
                string sql;
                for (int i = 0; i < ListIDEmp.Count; i++)
                {
                    sql = "insert into listeprive values('" + ListIDEmp.ElementAt(i) + "',(select now()),(select TIMESTAMPADD(day,30,(select now()))))";
                    // insert into listeprive values('M201545588875',(select now()),(select TIMESTAMPADD(day,30,(select now()))));
                    cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
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
            return "emprunteurs seront privés du service de réservation pendant 1 mois.";
        }

        public String supprimerCompte(String id)
        {
            MySqlConnection c = GetDBConnection();
            try
            {

                c.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            MySqlCommand cmd = c.CreateCommand();
            cmd.CommandText = "select * from emprunt where IDEmpr='" + id + "';";
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return "vous ne pouvez pas supprimer le compte tant qu'il a une réservation";
            }
            else
            {
                c.Close();
                c = GetDBConnection();
                try
                {
                    c.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                cmd = c.CreateCommand();
                cmd.CommandText = "select * from listeattente where IDEmpr='" + id + "';";
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return "vous ne pouvez pas supprimer le compte tant qu'il a une réservation";
                }
                else
                {
                    c.Close();
                    c = GetDBConnection();
                    try
                    {
                        c.Open();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    cmd = c.CreateCommand();
                    cmd.CommandText = "delete from emprunteur where ID='" + id + "'";
                    cmd.ExecuteNonQuery();
                    c.Close();
                    return "la suppression à été faite avec succés";
                }
            }
        }
        public Boolean authentificationBiblio(string pseudo, string password)
        {
            Boolean verifier = false;
            if (pseudo == "ilyes" && password == "12345")
            {
                verifier = true;
            }
            return verifier;
        }

        public List<emprunt> consulterEmprunt()
        {
            List<emprunt> listEmprunt = new List<emprunt>();
            emprunt emp = null;
            string IDEmpr;
            int codeBarre;
            int confirmer;
            Boolean V;
            DateTime dateEmp, dateFinEmp;
            try
            {
                MySqlConnection conn = GetDBConnection();
                conn.Open();
                //selection
                String sql = "Select * from emprunt";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    IDEmpr = input.GetString("IDEmpr");
                    Console.WriteLine(IDEmpr);
                    codeBarre = input.GetInt32("codeBarre");

                    dateEmp = input.GetDateTime("dateEmp");

                    dateFinEmp = input.GetDateTime("dateFinEmp");

                    confirmer = input.GetInt16("confirmer");
                    if (confirmer == 0)
                    {
                        V = false;
                    }
                    else
                    {
                        V = true;
                    }

                    emp = new emprunt(IDEmpr, codeBarre, V, dateEmp, dateFinEmp);
                    if (emp == null)
                    {
                        Console.WriteLine("emprunt null");
                    }

                    listEmprunt.Add(emp);


                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listEmprunt;
        }

        public List<etudiant> ConsulterEtudiant()
        {
            List<etudiant> listEtudiant = new List<etudiant>();
            etudiant etudiant;


            string numCarte, specialite, niveau, iD, nom, prenom, pseudo, password, typeEmp, email;
            int empNConfirme;

            try
            {
                MySqlConnection conn = GetDBConnection();
                conn.Open();
                //selection
                String sql = "Select * from emprunteur as em,etudiant as etd where em.ID=etd.numCarte";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    numCarte = input.GetString("ID");
                    specialite = input.GetString("specialite");

                    niveau = input.GetString("niveau");


                    iD = numCarte;
                    nom = input.GetString("nom");
                    prenom = input.GetString("prenom");
                    typeEmp = "etudiant";
                    empNConfirme = input.GetInt16("empNConfirme");
                    password = input.GetString("password");
                    pseudo = input.GetString("pseudo");
                    email = input.GetString("email");


                    etudiant = new etudiant(numCarte, specialite, niveau, iD, nom, prenom, pseudo, password, empNConfirme, typeEmp, email);
                    listEtudiant.Add(etudiant);


                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listEtudiant;
        }

        public List<enseignant> consulterEnseignant()
        {
            List<enseignant> listEnsaignant = new List<enseignant>();
            enseignant enseignant;
            string iD, nom, prenom, pseudo, password, typeEmp, email, grade, matricule;
            int empNConfirme;

            try
            {
                MySqlConnection conn = GetDBConnection();
                conn.Open();
                //selection
                String sql = "Select * from emprunteur as em,enseignant as ens where em.ID=ens.matricule";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader input = cmd.ExecuteReader();
                while (input.Read())
                {
                    matricule = input.GetString("ID");
                    grade = input.GetString("grade");
                    Console.WriteLine(grade);
                    iD = matricule;
                    nom = input.GetString("nom");
                    prenom = input.GetString("prenom");
                    typeEmp = "enseignant";
                    empNConfirme = input.GetInt16("empNConfirme");
                    password = input.GetString("password");
                    pseudo = input.GetString("pseudo");
                    email = input.GetString("email");




                    enseignant = new enseignant(matricule, grade, iD, nom, prenom, pseudo, password, empNConfirme, typeEmp, email);
                    listEnsaignant.Add(enseignant);

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return listEnsaignant;
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

        public string AjouterOvrg(int codeBarre, string Titre, String typeOvrg, string Auteur, string image, string Theme)
        {
            ouvrage ovrg = new ouvrage();
            int countRow1 = 0;
            MySqlConnection conn = null;
            try
            {
                conn = GetDBConnection();
                conn.Open();
                string sql = "insert into ouvrage values('" + codeBarre + "','" + Titre + "','" + typeOvrg + "','" + Auteur + "','" + image + "','" + Theme + "')";
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                countRow1 = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (countRow1 == 1)
            {
                return "L'opération d'ajout avec succes";
            }
            else
            {
                return "L'opération d'ajout est echoue ";

            }

        }
        public string ModifierOvrg(int codeBarre, string Titre, String typeOvrg, string Auteur, string image, string Theme)
        {
            ouvrage ovrg = new ouvrage();
            int countRow1 = 0;

            MySqlConnection conn = null;
            try
            {
                conn = GetDBConnection();
                conn.Open();
                //string date = "SELECT TIMESTAMPADD(day,15,'"+dateEmp+"')";
                string sql = "update ouvrage set codeBarre=" + codeBarre + ",titre='" + Titre + "',typeOvrg='" + typeOvrg + "',auteur='" + Auteur + "',img='" + image + "',theme='" + Theme + "' where codeBarre=" + codeBarre;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                countRow1 = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (countRow1 == 1)
            {
                return "L'opération de modification avec succes";
            }
            else
            {
                return "L'opération de modification est echoue ";

            }
        }

        public string supprimerOvrg(int codeBarre)
        {

            MySqlConnection c = null;
            try
            {
                c = GetDBConnection();
                c.Open();

                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "select * from emprunt where codeBarre=" + codeBarre;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return "vous ne pouvez pas supprimer l'ouvrage tant qu'il est emprunter";
                }
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                c = GetDBConnection();
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "select * from listeattente where codeBarre=" + codeBarre;
                MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return "vous ne pouvez pas supprimer l'ouvrage tant qu'il est attendue par un emprunteur";

                
            }
            c.Close();
        }

                     catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
                        
                        try
                        {
                c = GetDBConnection();
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd.CommandText = "delete from ouvrage where codeBarre=" + codeBarre;
                cmd.ExecuteNonQuery();
                c.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return "la suppression à été faite avec succés";
        }











        public delegate void rendreEventHandler(object source, string args);
        public static event rendreEventHandler Rendu;



        protected virtual void onRendre(String email)
        {
            Console.WriteLine(Rendu+" "+email);
            if (Rendu != null)
            {
                Rendu(this, email);

            }
        }




                public string rendre(string codeEmp, int codeBarre)
        {
            MySqlConnection c = null;
            int priorite;
            string IDEmpr="";
            string email = "";
            GestEmpImpl Gest = new GestEmpImpl();
            try
            {
                c = Conx.GetDBConnection();
                c.Open();
                MySqlCommand cmd = c.CreateCommand();
                cmd = c.CreateCommand();
                cmd.CommandText = "delete from emprunt where IDEmpr='" + codeEmp + "' and codeBarre=" + codeBarre;
                cmd.ExecuteNonQuery();

                c.Close();
                c.Open();

                 cmd = c.CreateCommand();
                cmd.CommandText = "select IDEmpr, priorite from listeattente where codeBarre=" + codeBarre;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    priorite = reader.GetInt16("priorite");
                    if (priorite == 1)
                    {
                        IDEmpr = reader.GetString("IDEmpr");
                    }
                }
                c.Close();
                Console.WriteLine(Gest.reserver(IDEmpr, codeBarre));//reserver automatiquement l'ouvrage lorsque on trouve un emprunteur dans la liste d'attente attend cet ouvrage(24h)
                c = Conx.GetDBConnection();
                c.Open();

                 cmd = c.CreateCommand();
                cmd.CommandText = "select email from emprunteur where ID='" + IDEmpr + "'";
                 reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    email = reader.GetString("email");
                }
                c.Close();
                onRendre(email);
                c = Conx.GetDBConnection();
                c.Open();

                 cmd = c.CreateCommand();
                cmd.CommandText = "delete from listeattente where IDEmpr='" + IDEmpr + "' and codeBarre=" + codeBarre;
                cmd.ExecuteNonQuery();


                c.Close();
                c = Conx.GetDBConnection();
                c.Open();

                 cmd = c.CreateCommand();
                cmd.CommandText = "update listeattente set priorite=priorite-1 where codeBarre=" + codeBarre;
                cmd.ExecuteNonQuery();


                c.Close();
                c = Conx.GetDBConnection();
         
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
                return email;
            



          
}

}
}