using System;
using System.Net.Http;
using System.Threading;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using ProtoBuf.Grpc.Client;
using SampleCodeFirstGrpcContracts;

using var channel = GrpcChannel.ForAddress("https://localhost:7104", new GrpcChannelOptions
{
    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
});

var client = channel.CreateGrpcService<ICalculatorService>();
var response = await client.Add10Async(
    new AddRequest { InputNumber = 5 }, CancellationToken.None);

Console.WriteLine(response.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
