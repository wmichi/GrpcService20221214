using System.Text;
using CompressionSampleContracts;

namespace CompressionSampleServer.Services;

public class CompressionSampleService : ICompressionSampleService
{
    public async Task<CompressionSample> GetAsync(CompressionRequest request, CancellationToken cancellationToken)
    {
        var data = Create(4100);
        // var data = Create(request.SizeInKib);
        return new CompressionSample
        {
            Data = data
        };
    }

    private string Create(int sizeInKib)
    {
        var sizeInBytes = sizeInKib * 1024;
        var repeatCount = sizeInBytes / "a".Length;

        var largeStringBuilder = new StringBuilder(sizeInBytes);
        for (int i = 0; i < repeatCount; i++)
        {
            largeStringBuilder.Append("a");
        }

        // Convert the StringBuilder to a string
        return largeStringBuilder.ToString();
    }
}
