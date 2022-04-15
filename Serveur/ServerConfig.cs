using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.ServiceModel;
using System.Windows.Forms;

namespace Serveur
{

    public enum ServiceTyp
    {
        WCF,
        gRPC,
        NetRemoting
    }
    public class ServerConfig
    {


        public ServiceTyp ServiceType { get; set; }

       

        public bool IsStarted { get; set; }

        public void StartServer(NetRemoteServer NETREMObj)
        {
            NETREMObj.channel = new TcpChannel(NETREMObj.Port);
            ChannelServices.RegisterChannel(NETREMObj.channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(BiblioImpl), "librarian", WellKnownObjectMode.Singleton);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(GestEmpImpl), "Emprunteur", WellKnownObjectMode.Singleton);
            IsStarted = true;
        }
        public bool StartServer(WCFServer WCFObj)
        {
            
            
            try
            {
              Uri url=new Uri("http://"+WCFObj.Address+":"+ WCFObj.Port+"/");

               WCFObj.Host= new ServiceHost(typeof(global::Serveur.GestEmpImpl), url);
                WCFObj.Host.Open();
                    IsStarted = true;
                    return true;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        
        }
        public void StartServer(gRPCServer gRPCObj)
        {
           
        }

        public bool IsChannelRegistered(TcpChannel channel)
        {
            if(channel!=null)
            {
                return ChannelServices.RegisteredChannels.First(ch => ch == channel) != null;
            }
            return false;
           
        }
        public void StopServer(NetRemoteServer NETREMOTEObj)
        {
            if(IsChannelRegistered(NETREMOTEObj.channel))
            {
                ChannelServices.UnregisterChannel(NETREMOTEObj.channel);
                IsStarted = false;
            }
            
        }
        public void StopServer(WCFServer WCFObj)
        {
           if(WCFObj.Host!=null)
            {
                WCFObj.Host.Close();
                IsStarted = false;
            }
               
            

        }





    }
}
