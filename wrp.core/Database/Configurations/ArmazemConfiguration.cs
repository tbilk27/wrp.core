using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ArmazemConfiguration : IEntityTypeConfiguration<Armazem>
    {
        public void Configure(EntityTypeBuilder<Armazem> builder)
        {
            builder.ToTable("Armazem");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Descricao).HasMaxLength(200).IsRequired();
            builder.HasIndex(o => o.Descricao).IsUnique(true);
        }
    }
}