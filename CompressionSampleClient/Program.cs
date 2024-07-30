using CompressionSampleContracts;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using ProtoBuf.Grpc.Client;

using var channel = GrpcChannel.ForAddress("https://localhost:7103", new GrpcChannelOptions
{
    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
});

var sampleClient = channel.CreateGrpcService<ICompressionSampleService>();
var response = await sampleClient.GetAsync(new CompressionRequest { SizeInKib = 1000 }, CancellationToken.None);

Console.WriteLine($"Result is '{response.Data.Length}'");
