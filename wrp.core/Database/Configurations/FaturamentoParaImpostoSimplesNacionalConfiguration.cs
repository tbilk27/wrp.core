using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FaturamentoParaImpostoSimplesNacionalConfiguration : IEntityTypeConfiguration<FaturamentoParaImpostoSimplesNacional>
    {
        public void Configure(EntityTypeBuilder<FaturamentoParaImpostoSimplesNacional> builder)
        {
            builder.ToTable("FaturamentoParaImpostoSimplesNacional");

            builder.HasKey(o => o.ID);
        }
    }
}