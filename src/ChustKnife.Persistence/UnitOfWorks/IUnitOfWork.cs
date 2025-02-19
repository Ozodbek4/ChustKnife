using ChustKnife.Domain.Entities;
using ChustKnife.Persistence.Repositories;

namespace ChustKnife.Persistence.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    // repositories
    IRepository<User> Users { get; }

    // methods
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    Task BeginTransactionAsync(CancellationToken cancellationToken = default);

    Task CommitTransactionAsync(CancellationToken cancellationToken = default);

    Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
}