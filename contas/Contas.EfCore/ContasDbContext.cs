using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Rsc28.Commons;

namespace Contas.EfCore;
public class ContasDbContext : DbContext
{
    public ContasDbContext(DbContextOptions<ContasDbContext> options) : base(options)
    {
    }

    public DbSet<Lancamento> Lancamentos { get; set; }
    public DbSet<TipoLancamento> TipoLancamentos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Model.GetEntityTypes()
            .Select(entityType => builder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name.ToSnakeCase()))
            .ToArray();

        base.OnModelCreating(builder);
        
        foreach(var entity in builder.Model.GetEntityTypes())
        {            
            foreach(var property in entity.GetProperties())
            {
                property.SetColumnName(property.Name.ToSnakeCase());
            }

            foreach(var key in entity.GetKeys())
            {
                key.SetName(key?.GetName()?.ToSnakeCase());
            }

            foreach(var key in entity.GetForeignKeys())
            {
                key.SetConstraintName(key.GetConstraintName()?.ToSnakeCase());
            }

            foreach(var index in entity.GetIndexes())
            {
                index.SetName(index.Name.ToSnakeCase());
            }
        }
    }
}
