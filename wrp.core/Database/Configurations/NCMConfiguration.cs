using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class NCMConfiguration : BaseConfiguration<NCM>
    {
        public void Configure(EntityTypeBuilder<NCM> builder)
        {
            builder.Property(p => p.CodigoNCM)
                .IsRequired();

            builder.HasIndex(p => p.CodigoNCM)
                .IsUnique();

            builder.Property(p => p.Descricao)
                .HasMaxLength(400)
                .IsRequired();
        }
    }
}