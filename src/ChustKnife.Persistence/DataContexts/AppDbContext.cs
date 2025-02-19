using ChustKnife.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChustKnife.Persistence.DataContexts;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
}