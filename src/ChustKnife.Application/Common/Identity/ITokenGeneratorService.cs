using ChustKnife.Domain.Entities;

namespace ChustKnife.Application.Common.Identity;

public interface ITokenGeneratorService
{
    Task<string> GenerateTokenAsync(User user, CancellationToken cancellationToken = default);
}