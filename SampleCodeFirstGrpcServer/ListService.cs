using SampleCodeFirstGrpcContracts;

namespace SampleCodeFirstGrpcServer;
public class ListService : IListService
{
    public async Task<IEnumerableResponse> GetIEnumerableAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new IEnumerableResponse()
            {
                Result = new List<string>()
            };
        }

        return new IEnumerableResponse()
        {
            Result = new List<string>(){ "test", "sample" }
        };
    }

    public async Task<IReadOnlyCollectionResponse> GetIReadOnlyCollectionAsync(ListRequest request,
        CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new IReadOnlyCollectionResponse()
            {
                Result = new List<string>()
            };
        }

        return new IReadOnlyCollectionResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<ICollectionResponse> GetICollectionAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new ICollectionResponse()
            {
                Result = new List<string>()
            };
        }

        return new ICollectionResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<IListResponse> GetIListAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new IListResponse()
            {
                Result = new List<string>()
            };
        }

        return new IListResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<ListResponse> GetListAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new ListResponse()
            {
                Result = new List<string>()
            };
        }
        return new ListResponse()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<ArrayResponse> GetArrayAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new ArrayResponse()
            {
                Result = new string[]{}
            };
        }

        return new ArrayResponse()
        {
            Result = new string[] { "test", "sample" }
        };
    }
}
