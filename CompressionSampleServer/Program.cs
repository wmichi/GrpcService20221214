using System.IO.Compression;
using CompressionSampleContracts;
using CompressionSampleServer.Services;
using ProtoBuf.Grpc.Server;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc(options =>
{
    options.EnableDetailedErrors = true;
    options.ResponseCompressionLevel = CompressionLevel.SmallestSize;
});

builder.Services.AddCodeFirstGrpc();
builder.Services.AddSingleton<ICompressionSampleService, CompressionSampleService>();

var app = builder.Build();

app.UseRouting();

app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });

app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<ICompressionSampleService>();
});

app.Run();