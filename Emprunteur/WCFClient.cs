using IGestEmpBiblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class WCFClient:Client
    {

        public ChannelFactory<IEmprunteur> ChanFact { get; set; }
    }
}
