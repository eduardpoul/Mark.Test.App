using System.ServiceModel;
using ProtoBuf.Grpc;
using TestApp.Contracts.Models;

namespace TestApp.Contracts.Grpc;


[ServiceContract]
public interface IProductsGrpcContract
{
    Task<List<ProductPc>> GetProductsAsync(CallContext callContext = default);
}