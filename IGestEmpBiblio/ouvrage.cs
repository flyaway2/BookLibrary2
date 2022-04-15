using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    [DataContract]
   public class ouvrage
    {
        private int codeBarre;
       private string titre,typeOvrg,auteur,img,theme;

        public ouvrage()
        {
        }

        public ouvrage(int codeBarre, string titre, string typeOvrg, string auteur, string img, string theme)
        {
            this.codeBarre = codeBarre;
            this.titre = titre;
            this.typeOvrg = typeOvrg;
            this.auteur = auteur;
            this.img = img;
            this.theme = theme;
        }
        private int myVar;
        [DataMember]
	public int MyProperty
	{
		get { return myVar;}
		set { myVar = value;}
	}
	    [DataMember]
        public int CodeBarre { get {return codeBarre;}
            set { codeBarre = value; }
        }
        [DataMember]
        public string Titre { get {return titre;}
            set { titre = value; }
        }
        [DataMember]
        public string TypeOvrg { get {return typeOvrg;}
            set { typeOvrg = value; }
        }
        [DataMember]
        public string Auteur { get{return auteur;}
            set { auteur = value; }
        }
        [DataMember]
        public string Img { get {return
            img;} set{ img = value; }
        }
        [DataMember]
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

    }
}
