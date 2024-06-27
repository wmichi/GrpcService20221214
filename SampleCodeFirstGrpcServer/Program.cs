using ProtoBuf.Grpc.Reflection;
using ProtoBuf.Grpc.Server;
using SampleCodeFirstGrpcContracts;
using SampleCodeFirstGrpcServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCodeFirstGrpc();
builder.Services.AddSingleton<ICalculatorService, CalculatorService>();

var app = builder.Build();

app.UseRouting();

app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });

app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<ICalculatorService>();
    endpoints.MapGrpcService<IListService>();
});


// for checking the generated proto file
var generator = new SchemaGenerator();
var schema = generator.GetSchema<IListService>();
Console.WriteLine(schema);

app.Run();