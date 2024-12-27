using VENative.Blazor.ServiceGenerator.Attributes;

namespace VENative.Blazor.ServiceGenerator.Examples.Client;

[GenerateClient(@namespace: "VENative.Blazor.ServiceGenerator.Examples.Client")]
public interface IProductService
{
    Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken = default);
}