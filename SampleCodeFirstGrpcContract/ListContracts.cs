using System;
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
    [Operation]
    Task<IEnumerableResponse> GetIEnumerableAsync(ListRequest request, CancellationToken cancellationToken);
    Task<IReadOnlyCollectionResponse> GetIReadOnlyCollectionAsync(ListRequest request, CancellationToken cancellationToken);
    Task<ICollectionResponse> GetICollectionAsync(ListRequest request, CancellationToken cancellationToken);
    Task<IListResponse> GetIListAsync(ListRequest request, CancellationToken cancellationToken);
    Task<ListResponse> GetListAsync(ListRequest request, CancellationToken cancellationToken);
    Task<ArrayResponse> GetArrayAsync(ListRequest request, CancellationToken cancellationToken);
}

[ProtoContract]
public class ListRequest
{
    [ProtoMember(1)]
    public bool IsEmpty { get; set; }
}

[ProtoContract]
public class IEnumerableResponse
{
    [ProtoMember(1)] public IEnumerable<string> Result { get; set; } = new List<string>();
}

[ProtoContract]
public class IReadOnlyCollectionResponse
{
    [ProtoMember(1)] public IReadOnlyCollection<string> Result { get; set; } = new List<string>();
}

[ProtoContract]
public class ICollectionResponse
{
    [ProtoMember(1)]
    public ICollection<string> Result { get; set; } = new List<string>();
}

[ProtoContract]
public class IListResponse
{
    [ProtoMember(1)]
    public IList<string> Result { get; set; } = new List<string>();
}

[ProtoContract]
public class ListResponse
{
    [ProtoMember(1)] 
    public List<string> Result { get; set; } = new ();
}

[ProtoContract]
public class ArrayResponse
{
    [ProtoMember(1)]
    public string[] Result { get; set; } = Array.Empty<string>();
}