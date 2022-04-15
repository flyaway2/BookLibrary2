using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    public interface IBibliothècaire
    {
        
        List<ouvrage> chercherOvrg(ouvrage ovrg, String Choix);
        List<ouvrage> ConsulterOvrg();
       string AjouterCompte(string iD, string nom, string prenom, string pseudo, string password,string email,string spec,string niveau,string grade,string typeEmp);
        string Emprunter(string IDEmpr, int codeBarre);
        string PriveDuService(string IDEmpr);
        Boolean authentificationBiblio(string pseudo, string password);
         List<emprunt> consulterEmprunt();
        List<enseignant> consulterEnseignant();
        List<etudiant> ConsulterEtudiant();
        String supprimerCompte(String id);
        string AjouterOvrg(int codeBarre, string Titre, String typeOvrg, string Auteur, string image, string Theme);
        string ModifierOvrg(int codeBarre, string Titre, String typeOvrg, string Auteur, string image, string Theme);
        string supprimerOvrg(int codeBarre);
    
        string rendre(string codeEmp, int codeBarre);

        /*
ConsulterOvrg
ChercherOvrg
Emprunter
Rendre
PriveDuService
AjouterOvrg
SupprimerCompte
AjourterCompte
NotifierParMail

    */
    }
}
