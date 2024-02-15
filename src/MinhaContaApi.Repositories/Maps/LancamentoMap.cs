using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinhaContaApi.Repositories.Models;

namespace MinhaContaApi.Repositories.Maps;

public class LancamentoMap : IEntityTypeConfiguration<LancamentoModel>
{
    public void Configure(EntityTypeBuilder<LancamentoModel> builder)
    {
       builder.ToTable("lancamentos");
       builder.HasKey(e => e.Id);
       
       builder.Property(e => e.Id)
           .HasColumnType("int")
           .HasColumnName("id")
           .ValueGeneratedOnAdd();
       
       builder.Property(e => e.UserId)
           .HasColumnType("varchar(36)")
           .HasColumnName("user_id");
       
       builder.Property(e => e.ExternalId)
           .HasColumnType("varchar(36)")
           .HasColumnName("external_id");
       
       builder.Property(e => e.Descricao)
           .HasColumnType("varchar(200)")
           .HasColumnName("descricao");
       
       builder.Property(e => e.Valor)
           .HasColumnType("decimal(10,2)")
           .HasColumnName("valor");
       
       builder.Property(e => e.Data)
           .HasColumnType("date")
           .HasColumnName("data");
    }
}