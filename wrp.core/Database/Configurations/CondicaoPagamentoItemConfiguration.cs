using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CondicaoPagamentoItemConfiguration : BaseConfiguration<CondicaoPagamentoItem>
    {
        public void Configure(EntityTypeBuilder<CondicaoPagamentoItem> builder)
        {
            builder.Property(c => c.Dias)
                .IsRequired();
        }
    }
}