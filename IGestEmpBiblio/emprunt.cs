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
    public class emprunt
    {
        private string IDEmpr;
        private int codeBarre;
        private Boolean confirmer;
        private DateTime dateEmp, dateFinEmp;
        private int cnfirmer;

        public emprunt()
        {
        }

        public emprunt(string IDEmpr, int codeBarre, bool confirmer, DateTime dateEmp, DateTime dateFinEmp)
        {
            this.IDEmpr = IDEmpr;
            this.codeBarre = codeBarre;
            this.confirmer = confirmer;
            this.dateEmp = dateEmp;
            this.dateFinEmp = dateFinEmp;
        }
        [DataMember]
        public string IDEmpr1 { get {return IDEmpr;} set { IDEmpr = value; }}
        [DataMember]
        public int CodeBarre { get {return codeBarre;} set { codeBarre = value; }}
        [DataMember]
        public bool Confirmer { get { return confirmer;} set { confirmer = value; }}
        [DataMember]
        public DateTime DateEmp { get {return dateEmp;} set { dateEmp = value; }}
        [DataMember]
        public DateTime DateFinEmp { get {return dateFinEmp;} set { dateFinEmp = value; }}
        [DataMember]
        public int Cnfirmer { get { return cnfirmer; } set { cnfirmer = value; } }
    }
}
