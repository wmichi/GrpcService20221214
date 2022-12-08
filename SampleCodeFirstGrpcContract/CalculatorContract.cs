using System.Threading;
using System.Threading.Tasks;
using ProtoBuf;
using ProtoBuf.Grpc.Configuration;

namespace SampleCodeFirstGrpcContracts;

[Service]
public interface ICalculatorService
{
    [Operation]
    Task<AddResponse> Add10Async(AddRequest request, CancellationToken cancellationToken);
}

[ProtoContract]
public class AddRequest
{
    [ProtoMember(1)]
    public int InputNumber { get; set; }
}

[ProtoContract]
public class AddResponse
{
    [ProtoMember(1)]
    public string Message { get; set; }
}