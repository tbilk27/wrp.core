using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ArmazemConfiguration :BaseConfiguration<Armazem>
    {
        public void Configure(EntityTypeBuilder<Armazem> builder)
        {
            builder.Property(o => o.Descricao).HasMaxLength(200).IsRequired();
            builder.HasIndex(o => o.Descricao).IsUnique(true);
        }
    }
}