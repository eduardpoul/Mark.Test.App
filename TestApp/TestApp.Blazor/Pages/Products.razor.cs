using Microsoft.AspNetCore.Components;
using TestApp.Contracts.Grpc;
using TestApp.Contracts.Models;

namespace TestApp.Blazor.Pages;

[Route("")]
public partial class Products
{
    private List<ProductPc> ProductsList { get; set; } = new();
    
    [Inject]
    private IProductsGrpcContract _productsGrpcContract { get; set; }
    
    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ProductsList = await _productsGrpcContract.GetProductsAsync();
    }
}