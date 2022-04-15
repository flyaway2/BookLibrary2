using IGestEmpBiblio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class ClientConfig
    {

        public bool IsConnected { get; set; }
        public IEmprunteur SetConfig(NETREMOTEClient NETREMOTEObj)
        {
            try
            {
                NETREMOTEObj.channel = new TcpChannel();
                IChannel[] chlist = ChannelServices.RegisteredChannels;
                if(chlist.Count()==0)
                {
                    ChannelServices.RegisterChannel(NETREMOTEObj.channel, false);
                }
               
                string url = "tcp://"+ NETREMOTEObj.Address + ":" + NETREMOTEObj.Port + "/Emprunteur";
                IsConnected = true;
                IEmprunteur IEmpr = (IEmprunteur)Activator.GetObject(typeof(IEmprunteur), url);
                IEmpr.IsActive();
                return IEmpr;
               
            }
            catch(Exception ex)
            {
                throw ex;
            }
         
        }
        public void DisconnectFromServer(WCFClient WCFObj)
        {
            WCFObj.ChanFact.Close();
            IsConnected = false;
        }
        public IEmprunteur SetConfig(WCFClient WCFObj)
        {
            try
            {
                var myBinding = new BasicHttpBinding();
                var myEndpoint = new EndpointAddress("http://" + WCFObj.Address + ":" + WCFObj.Port + "/Emprunteur");
                WCFObj.ChanFact= new ChannelFactory<IEmprunteur>(myBinding, myEndpoint);
                IEmprunteur client = null;
                 client = WCFObj.ChanFact.CreateChannel();
                bool IsActive= client.IsActive();
              
                 IsActive = client.IsActive();
                IsConnected = true;
                return client;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
