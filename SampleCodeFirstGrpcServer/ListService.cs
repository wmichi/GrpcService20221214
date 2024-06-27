using SampleCodeFirstGrpcContracts;

namespace SampleCodeFirstGrpcServer;
public class ListService : IListService
{
    public async Task<IEnumerableResponse> GetIEnumerableAsync(ListRequest request, CancellationToken cancellationToken)
    {
        return new IEnumerableResponse()
        {
            Result = new List<string>(){ "test", "sample" }
        };
    }

    public async Task<IReadOnlyCollectionResponse> GetIReadOnlyCollectionAsync(ListRequest request,
        CancellationToken cancellationToken)
    {
        return new IReadOnlyCollectionResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };

    }

    public async Task<ICollectionResponse> GetICollectionAsync(ListRequest request, CancellationToken cancellationToken)
    {
        return new ICollectionResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };

    }

    public async Task<IListResponse> GetIListAsync(ListRequest request, CancellationToken cancellationToken)
    {
        return new IListResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };

    }

    public async Task<ListResponse> GetListAsync(ListRequest request, CancellationToken cancellationToken)
    {
        return new ListResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };

    }

    public async Task<ArrayResponse> GetArrayAsync(ListRequest request, CancellationToken cancellationToken)
    {
        return new ArrayResponse()
        {
            Result = new string[] { "test", "sample" }
        };

    }
}
