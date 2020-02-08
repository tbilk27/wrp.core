using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ModeloComissaoItemConfiguration : BaseConfiguration<ModeloComissaoItem>
    {
        public void Configure(EntityTypeBuilder<ModeloComissaoItem> builder)
        {
            builder.HasOne<ModeloComissao>()
                .WithMany(m => m.Itens)
                .HasForeignKey(m => m.IDModeloComissao);
        }
    }
}