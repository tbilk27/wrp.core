using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class AtributoValorConfiguration : BaseConfiguration<AtributoValor>
    {
        public void Configure(EntityTypeBuilder<AtributoValor> builder)
        {
            builder.Property(o => o.Descricao)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}