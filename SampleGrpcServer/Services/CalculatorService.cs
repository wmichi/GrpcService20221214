using System.Threading.Tasks;
using Grpc.Core;

namespace SampleGrpcServer.Services;

public class CalculatorService : Calculator.CalculatorBase
{
    public override Task<AddResponse> Add10(AddRequest request, ServerCallContext context)
    {
        return Task.FromResult(new AddResponse
        {
            Message = $"Result is {request.InputNumber + 10}"
        });
    }
}
