using VENative.Blazor.ServiceGenerator.Attributes;

namespace VENative.Blazor.ServiceGenerator.Tests.TestInterfaces;

[GenerateHub("VENative.Blazor.ServiceGenerator.Tests.TestInterfaces", $"/{nameof(IProductService)}")]
public class ProductService : IProductService
{
    public Task CreateUserAsync(User user, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUserByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetUserNameByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<string>> GetUserNamesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<string>> GetUserNamesWithTokenAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<string> StreamUserNames(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IAsyncEnumerable<User> StreamUsers(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
