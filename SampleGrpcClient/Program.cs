using System;
using System.Net.Http;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using SampleGrpcClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7103", new GrpcChannelOptions
{
    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
});

var client = new Calculator.CalculatorClient(channel);
var response = await client.Add10Async(
    new AddRequest {InputNumber = 5});

Console.WriteLine(response.Message);