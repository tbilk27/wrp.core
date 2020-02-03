using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CategoriaProdutoConfiguration : IEntityTypeConfiguration<CategoriaProduto>
    {
        public void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            builder.ToTable("CategoriaProduto");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Descricao).HasMaxLength(200).IsRequired();
            builder.HasIndex(o => new { o.IDEmpresa, o.Descricao }).IsUnique();
        }
    }
}