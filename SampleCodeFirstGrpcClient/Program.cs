using System;
using System.Net.Http;
using System.Threading;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using ProtoBuf.Grpc.Client;
using SampleCodeFirstGrpcContracts;

using var channel = GrpcChannel.ForAddress("https://localhost:7103", new GrpcChannelOptions
{
    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
});

var client = channel.CreateGrpcService<ICalculatorService>();
var response = await client.Add10Async(
    new AddRequest { InputNumber = 5 }, CancellationToken.None);

Console.WriteLine(response.Message);
Console.WriteLine("Press any key to exit...");

var listClient = channel.CreateGrpcService<IListService>();

try
{
    var ienumerableResponse = await listClient.GetIEnumerableAsync(
        new ListRequest { Id = "test" }, CancellationToken.None);
    Console.WriteLine(ienumerableResponse.Result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("GetIEnumerableAsync Failed");
}

try
{
    var ireadonlycollectionResponse = await listClient.GetIReadOnlyCollectionAsync(
        new ListRequest { Id = "test" }, CancellationToken.None);
    Console.WriteLine(ireadonlycollectionResponse.Result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("GetIReadOnlyCollectionAsync Failed");
}

try
{
    var ilistResponse = await listClient.GetIListAsync(
        new ListRequest { Id = "test" }, CancellationToken.None);
    Console.WriteLine(ilistResponse.Result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("GetIListAsync Failed");
}

try
{
    var listResponse = await listClient.GetListAsync(
        new ListRequest { Id = "test" }, CancellationToken.None);
    Console.WriteLine(listResponse.Result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("GetListAsync Failed");
}

try
{
    var arrayResponse = await listClient.GetArrayAsync(
        new ListRequest { Id = "test" }, CancellationToken.None);
    Console.WriteLine(arrayResponse.Result);
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine("GetArrayAsync Failed");
}

Console.ReadKey();
