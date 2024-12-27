using VENative.Blazor.ServiceGenerator.Attributes;

namespace VENative.Blazor.ServiceGenerator.Tests.TestInterfaces;

[GenerateClient]
public interface IProductService
{
    Task CreateUserAsync(User user, CancellationToken cancellationToken = default);
    Task DeleteUserByIdAsync(Guid id, CancellationToken cancellationToken = default);
    IAsyncEnumerable<User> StreamUsers(CancellationToken cancellationToken = default);
    IAsyncEnumerable<string> StreamUserNames(CancellationToken cancellationToken = default);
    Task<IEnumerable<string>> GetUserNamesWithTokenAsync(CancellationToken cancellationToken = default);
    Task<IEnumerable<string>> GetUserNamesAsync();
    Task<string> GetUserNameByIdAsync(Guid id, CancellationToken cancellationToken = default);
}

public record User(Guid Id, string Name);