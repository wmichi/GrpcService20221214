using SampleCodeFirstGrpcContracts;

namespace SampleCodeFirstGrpcServer;

public class CalculatorService : ICalculatorService
{
    public async Task<AddResponse> Add10Async(AddRequest request, CancellationToken cancellationToken)
    {
        return new AddResponse
        {
            Message = $"Result is {request.InputNumber + 10}"
        };
    }
}
