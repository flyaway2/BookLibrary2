using System;
using System.Runtime.Serialization;


namespace IGestEmpBiblio
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(etudiant))]
    [KnownType(typeof(enseignant))]
    public class emprunteur
    {
        private string ID,nom,prenom,pseudo,password,typeEmp,email;
        private int empNConfirme;
        public emprunteur()
        {

        }

        public emprunteur(string iD, string nom, string prenom, string pseudo, string password, int empNConfirme,string typeEmp,string email)
        {
            ID = iD;
            this.nom = nom;
            this.prenom = prenom;
            this.pseudo = pseudo;
            this.password = password;
            this.empNConfirme = empNConfirme;
            this.typeEmp = typeEmp;
            this.email = email;
        }

        [DataMember]
        public string ID1 { get{return ID;}
            set { ID = value; }
        }
        [DataMember]
        public string Nom { get {return nom;}
            set{ nom = value; }
        }
        [DataMember]
        public string Prenom { get {return prenom;} set { prenom = value; }}
        [DataMember]
        public string Pseudo { get {return pseudo;} set { pseudo = value; }}
        [DataMember]
        public string Password { get {return password;} set { password = value; }}
        [DataMember]
        public int EmpNConfirme { get {return empNConfirme;} set { empNConfirme = value; }}
        [DataMember]
        public string TypeEmp { get { return typeEmp;} set{ typeEmp=value; }}
        [DataMember]
        public string Email { get { return email; } set { email = value; } }
    }
}
