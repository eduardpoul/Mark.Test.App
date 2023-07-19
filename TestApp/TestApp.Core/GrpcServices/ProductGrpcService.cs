using ProtoBuf.Grpc;
using TestApp.Contracts.Grpc;
using TestApp.Contracts.Models;
using TestApp.Services;

namespace TestApp.GrpcServices;

public class ProductGrpcService : IProductsGrpcContract
{
    private readonly IProductService _productService;
    
    public ProductGrpcService(
        IProductService productService)
    {
        _productService = productService;
    }
    
    public async Task<List<ProductPc>> GetProductsAsync(CallContext callContext = default)
    {
        return await _productService.GetProductsAsync(callContext.CancellationToken);
    }
}