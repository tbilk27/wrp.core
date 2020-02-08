using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;]
using wrp.core.Entity.Global;

namespace wrp.core.Database.Configurations
{
    public class FilialItemListaServicoConfiguration : BaseConfiguration<FilialItemListaServico>
    {
        public void Configure(EntityTypeBuilder<FilialItemListaServico> builder)
        {
            builder.HasOne<ItemListaServico>()
                .WithMany(l => l.FilialItemListaServicos)
                .HasForeignKey(l => l.IDItemListaServico);

            builder.HasOne<CSTISS>()
                .WithMany(c => c.FilialItemListaServicos)
                .HasForeignKey(c => c.IDCSTISS);
        }
    }
}