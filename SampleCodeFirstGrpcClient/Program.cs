using System;
using System.Linq;
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

//var client = channel.CreateGrpcService<ICalculatorService>();
//var response = await client.Add10Async(
//    new AddRequest { InputNumber = 5 }, CancellationToken.None);

//Console.WriteLine(response.Message);

var isEmpty = true;
Console.WriteLine($"IsEmpty = {isEmpty}");

var listClient = channel.CreateGrpcService<IListService>();

//try
//{
//    var ienumerableResponse = await listClient.GetIEnumerableAsync(
//        new ListRequest { IsEmpty = isEmpty }, CancellationToken.None);
//    Console.WriteLine(ienumerableResponse.Result);
//    Console.WriteLine(ienumerableResponse.Result.FirstOrDefault());
//    Console.WriteLine("GetIEnumerableAsync Succeeded");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex);
//    Console.WriteLine("GetIEnumerableAsync Failed");
//}

try
{
    var ireadonlycollectionResponse = await listClient.GetIReadOnlyCollectionAsync(
        new ListRequest { IsEmpty = isEmpty }, CancellationToken.None);
    Console.WriteLine(ireadonlycollectionResponse.Result);
    Console.WriteLine(ireadonlycollectionResponse.Result.FirstOrDefault());
    Console.WriteLine("GetIReadOnlyCollectionAsync Succeeded");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("GetIReadOnlyCollectionAsync Failed");
}

try
{
    var icollectionResponse = await listClient.GetICollectionAsync(
        new ListRequest { IsEmpty = isEmpty }, CancellationToken.None);
    Console.WriteLine(icollectionResponse.Result);
    Console.WriteLine(icollectionResponse.Result.FirstOrDefault());
    Console.WriteLine("GetICollectionAsync Succeeded");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("GetICollectionAsync Failed");
}

try
{
    var ilistResponse = await listClient.GetIListAsync(
        new ListRequest { IsEmpty = isEmpty }, CancellationToken.None);
    Console.WriteLine(ilistResponse.Result);
    Console.WriteLine(ilistResponse.Result.FirstOrDefault());
    Console.WriteLine("GetIListAsync Succeeded");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("GetIListAsync Failed");
}

try
{
    var listResponse = await listClient.GetListAsync(
        new ListRequest { IsEmpty = isEmpty }, CancellationToken.None);
    Console.WriteLine(listResponse.Result);
    Console.WriteLine(listResponse.Result.FirstOrDefault());
    Console.WriteLine("GetListAsync Succeeded");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("GetListAsync Failed");
}

try
{
    var arrayResponse = await listClient.GetArrayAsync(
        new ListRequest { IsEmpty = isEmpty }, CancellationToken.None);
    Console.WriteLine(arrayResponse.Result);
    Console.WriteLine(arrayResponse.Result.FirstOrDefault());
    Console.WriteLine("GetArrayAsync Succeeded");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    Console.WriteLine("GetArrayAsync Failed");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();
