using VENative.Blazor.ServiceGenerator.Attributes;
using VENative.Blazor.ServiceGenerator.Examples.Client;

namespace VENative.Blazor.ServiceGenerator.Examples;

[GenerateHub]
public class ProductService : IProductService
{
    private static readonly Product[] products =
    [
        new Product(0, "Product1"),
        new Product(1, "Product2"),
        new Product(2, "Product3"),
        new Product(3, "Product4"),
    ];

    public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default)
    {
        // Delay to simulate fetching data
        await Task.Delay(3000, cancellationToken);
        return products;
    }
}