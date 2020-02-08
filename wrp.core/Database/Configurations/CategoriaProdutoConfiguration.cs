using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CategoriaProdutoConfiguration : BaseConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder.Property(o => o.Descricao)
                .HasMaxLength(200)
                .IsRequired();
            builder.HasIndex(o => new { o.IDEmpresa, o.Descricao })
                .IsUnique();
        }
    }
}