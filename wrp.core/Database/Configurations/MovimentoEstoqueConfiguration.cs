using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class MovimentoEstoqueConfiguration : BaseConfiguration<MovimentoEstoque>
    {
        public void Configure(EntityTypeBuilder<MovimentoEstoque> builder)
        {
            builder.HasOne<ProdutoLoteItem>()
                .WithMany(p => p.MovimentoEstoque)
                .HasForeignKey(p => p.IDProdutoLoteItem)
                .IsRequired();

            builder.Property(p => p.Historico)
                .HasMaxLength(200);

            builder.Property(p => p.DataMovimento)
                .IsRequired();
        }
    }
}