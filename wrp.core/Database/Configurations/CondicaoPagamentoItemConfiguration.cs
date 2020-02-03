using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CondicaoPagamentoItemConfiguration : IEntityTypeConfiguration<CondicaoPagamentoItem>
    {
        public void Configure(EntityTypeBuilder<CondicaoPagamentoItem> builder)
        {
            builder.ToTable("CondicaoPagamentoItem");

            builder.HasKey(o => o.ID);

            builder.Property(c => c.Dias)
                .IsRequired();
        }
    }
}