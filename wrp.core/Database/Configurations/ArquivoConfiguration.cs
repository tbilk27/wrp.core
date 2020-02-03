using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ArquivoConfiguration : IEntityTypeConfiguration<Arquivo>
    {
        public void Configure(EntityTypeBuilder<Arquivo> builder)
        {
            builder.ToTable("Arquivo");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Nome).HasMaxLength(260).IsRequired();
            builder.Property(o => o.Mime).HasMaxLength(50);
            builder.Property(o => o.Extensao).HasMaxLength(50);
        }
    }
}