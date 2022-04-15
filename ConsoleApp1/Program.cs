using Grpc.Net.Client;
using GrpcService;
using System;
using System.Net.Http;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext.SetSwitch(
   "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            string url = "http://localhost:5000";

            GrpcChannel channel = GrpcChannel.ForAddress(url);
            Greeter.GreeterClient client = new Greeter.GreeterClient(channel);
            HelloRequest HelReq = new HelloRequest();
            HelReq.Name = "amine";
            var resp = client.SayHello(HelReq);
            Console.WriteLine(resp.Message);
            Console.ReadLine();
        }
    }
}
