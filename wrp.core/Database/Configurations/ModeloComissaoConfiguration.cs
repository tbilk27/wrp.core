using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ModeloComissaoConfiguration : BaseConfiguration<ModeloComissao>
    {
        public void Configure(EntityTypeBuilder<ModeloComissao> builder)
        {
            builder.Property(p => p.Descricao)
                .HasMaxLength(200);
        }
    }
}