using Microsoft.Extensions.Primitives;
using ProtoBuf;
using ProtoBuf.Grpc.Configuration;

namespace CompressionSampleContracts;

[Service]
public interface ICompressionSampleService
{
    [Operation]
    Task<CompressionSample> GetAsync(CompressionRequest request, CancellationToken cancellationToken);
}


[ProtoContract]
public class CompressionSample
{
    [ProtoMember(1)]
    public string Data { get; set; }
}

[ProtoContract]
public class CompressionRequest
{
    public int SizeInKib { get; set; }
}