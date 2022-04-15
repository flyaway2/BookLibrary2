using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serveur
{
    public abstract class Serveur
    {
        public  int Port { get; set; }

        public string Address { get; set; }
    }
}
