using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ArquivoConfiguration : BaseConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.Property(o => o.Nome)
                .HasMaxLength(260)
                .IsRequired();
            builder.Property(o => o.Mime)
                .HasMaxLength(50);
            builder.Property(o => o.Extensao)
                .HasMaxLength(50);
        }
    }
}