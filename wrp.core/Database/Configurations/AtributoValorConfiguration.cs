using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class AtributoValorConfiguration : IEntityTypeConfiguration<AtributoValor>
    {
        public void Configure(EntityTypeBuilder<AtributoValor> builder)
        {
            builder.ToTable("AtributoValor");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Descricao).HasMaxLength(200).IsRequired();
            
        }
    }
}
