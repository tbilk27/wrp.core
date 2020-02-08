using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class BancoConfiguration : BaseConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.Property(o => o.Descricao)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(o => o.Febraban)
                .HasMaxLength(4)
                .IsRequired();
            builder.HasIndex(o => new { o.IDEmpresa, o.IDFilial, o.Febraban })
                .IsUnique();
        }
    }
}