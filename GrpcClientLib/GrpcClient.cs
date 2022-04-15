using Grpc.Net.Client;
using GrpcService;
using System;

namespace GrpcClientLib
{
    public class GrpcClient
    {

        public Greeter.GreeterClient client { get; set; }
        public void setup()
        {
            AppContext.SetSwitch(
  "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            string url = "http://localhost:5000";
            GrpcChannel channel = GrpcChannel.ForAddress(url);
            client = new Greeter.GreeterClient(channel);
           
        }
        public string gretting()
        {
            HelloRequest HelReq = new HelloRequest();
            HelReq.Name = "amine";
            var resp = client.SayHello(HelReq);
            return resp.Message;
        }
    }
}
