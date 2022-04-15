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
    public class listePrive
    {
        private string IDEmpr;
        private DateTime dateD, dateF;

        public listePrive(string iDEmpr, DateTime dateD, DateTime dateF)
        {
            IDEmpr = iDEmpr;
            this.dateD = dateD;
            this.dateF = dateF;
        }
        [DataMember]
        public DateTime DateD { get {return dateD;} set { dateD = value; }}
        [DataMember]
        public DateTime DateF { get {return dateF;} set { dateF = value; }}
        [DataMember]
        public string IDEmpr1 { get { return IDEmpr; } set { IDEmpr = value; } }
    }
}
