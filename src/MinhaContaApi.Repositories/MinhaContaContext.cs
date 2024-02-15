using Microsoft.EntityFrameworkCore;
using MinhaContaApi.Repositories.Models;

namespace MinhaContaApi.Repositories;

public class MinhaContaContext : DbContext
{
    public MinhaContaContext(DbContextOptions<MinhaContaContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MinhaContaContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<LancamentoModel> Lancamentos { get; set; }
}