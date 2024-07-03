using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProtoBuf;
using ProtoBuf.Grpc.Configuration;

namespace SampleCodeFirstGrpcContracts;

[Service]
public interface IListService
{
    //[Operation]
    //Task<IEnumerableResponse<string>> GetIEnumerableAsync(ListRequest request, CancellationToken cancellationToken);

    [Operation]
    Task<IReadOnlyCollectionResponse<string>> GetIReadOnlyCollectionAsync(ListRequest request, CancellationToken cancellationToken);

    [Operation]
    Task<ICollectionResponse<string>> GetICollectionAsync(ListRequest request, CancellationToken cancellationToken);

    [Operation]
    Task<IListResponse<string>> GetIListAsync(ListRequest request, CancellationToken cancellationToken);
    
    [Operation]
    Task<ListResponse<string>> GetListAsync(ListRequest request, CancellationToken cancellationToken);

    [Operation]
    Task<ArrayResponse<string>> GetArrayAsync(ListRequest request, CancellationToken cancellationToken);
}

[ProtoContract]
public class ListRequest
{
    [ProtoMember(1)]
    public bool IsEmpty { get; init; }
}

[ProtoContract]
public class Response<TResult>
{
    [ProtoMember(1)]
    public virtual TResult Result { get; init; }
}

//[ProtoContract]
//public class IEnumerableResponse<TResult> : Response<IEnumerable<TResult>>
//{
//    [ProtoMember(1, OverwriteList = true)]
//    public override IEnumerable<TResult> Result { get; init; } = Array.Empty <TResult> ();
//}



[ProtoContract]
public class IReadOnlyCollectionResponse<TResult> : Response<IReadOnlyCollection<TResult>>
{
    [ProtoMember(1, OverwriteList = true)] 
    public override IReadOnlyCollection<TResult> Result { get; init; } = Array.Empty<TResult>();
}

public static class IReadOnlyCollectionResponse
{
    public static IReadOnlyCollectionResponse<TResult> Ok<TResult>(IReadOnlyCollection<TResult> result) =>
        new()
        {
            Result = result
        };
}

[ProtoContract]
public class ICollectionResponse<TResult> : Response<ICollection<TResult>>
{
    [ProtoMember(1, OverwriteList = true)]
    public override ICollection<TResult> Result { get; init; } = Array.Empty<TResult>();
}

[ProtoContract]
public class IListResponse<TResult> : Response<IList<TResult>>
{
    [ProtoMember(1, OverwriteList = true)]
    public override IList<TResult> Result { get; init; }  = Array.Empty<TResult>();
}

[ProtoContract]
public class ListResponse<TResult> : Response<List<TResult>>
{
    [ProtoMember(1, OverwriteList = true)]
    public override List<TResult> Result { get; init; } = new ();
}

[ProtoContract]
public class ArrayResponse<TResult> : Response<TResult[]>
{
    [ProtoMember(1, OverwriteList = true)]
    public override TResult[] Result { get; init; } = Array.Empty<TResult>();
}