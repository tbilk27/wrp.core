using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CondicaoPagamentoConfiguration : IEntityTypeConfiguration<CondicaoPagamento>
    {
        public void Configure(EntityTypeBuilder<CondicaoPagamento> builder)
        {
            builder.ToTable("CondicaoPagamento");

            builder.HasKey(o => o.ID);

            builder.Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Desconto)
                .IsRequired();

            builder.Property(p => p.Acrescimo)
                .IsRequired();

            builder.Property(p => p.ValorMinimo)
                .IsRequired();

            builder.HasMany(c => c.Itens)
                .WithOne(c => c.CondicaoPagamento)
                .HasForeignKey(c => c.IDCondicaoPagamento)
                .IsRequired();
        }
    }
}