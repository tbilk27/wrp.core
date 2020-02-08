using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class LocalConfiguration : BaseConfiguration<Local>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.HasOne<Armazem>()
                .WithMany(a => a.Locais)
                .HasForeignKey(a => a.IDArmazem)
                .IsRequired();

            builder.HasIndex(a => a.IDArmazem)
                .IsUnique();

            builder.Property(a => a.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasIndex(a => a.Descricao)
                .IsUnique();
        }
    }
}