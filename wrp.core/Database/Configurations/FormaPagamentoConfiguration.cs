using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FormaPagamentoConfiguration : BaseConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}