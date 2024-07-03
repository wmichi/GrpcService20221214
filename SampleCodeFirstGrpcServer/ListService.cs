using SampleCodeFirstGrpcContracts;

namespace SampleCodeFirstGrpcServer;
public class ListService : IListService
{
    //public async Task<IEnumerableResponse> GetIEnumerableAsync(ListRequest request, CancellationToken cancellationToken)
    //{
    //    if (request.IsEmpty)
    //    {
    //        return new IEnumerableResponse()
    //        {
    //            Result = new List<string>()
    //        };
    //    }

    //    return new IEnumerableResponse()
    //    {
    //        Result = new List<string>(){ "test", "sample" }
    //    };
    //}

    public async Task<IReadOnlyCollectionResponse<string>> GetIReadOnlyCollectionAsync(ListRequest request,
        CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new IReadOnlyCollectionResponse<string>()
            {
                Result = new List<string>()
            };
        }

        return new IReadOnlyCollectionResponse<string>()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<ICollectionResponse<string>> GetICollectionAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new ICollectionResponse<string>()
            {
                Result = new List<string>()
            };
        }

        return new ICollectionResponse<string>()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<IListResponse<string>> GetIListAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new IListResponse<string>()
            {
                Result = new List<string>()
            };
        }

        return new IListResponse<string>()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<ListResponse<string>> GetListAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new ListResponse<string>()
            {
                Result = new List<string>()
            };
        }
        return new ListResponse<string>()
        {
            Result = new List<string>() { "test", "sample" }
        };
    }

    public async Task<ArrayResponse<string>> GetArrayAsync(ListRequest request, CancellationToken cancellationToken)
    {
        if (request.IsEmpty)
        {
            return new ArrayResponse<string>()
            {
                Result = new string[]{}
            };
        }

        return new ArrayResponse<string>()
        {
            Result = new string[] { "test", "sample" }
        };
    }
}
