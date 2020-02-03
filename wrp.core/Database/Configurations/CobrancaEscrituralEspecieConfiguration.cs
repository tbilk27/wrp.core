using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CobrancaEscrituralEspecieConfiguration : IEntityTypeConfiguration<CobrancaEscrituralEspecie>
    {
        public void Configure(EntityTypeBuilder<CobrancaEscrituralEspecie> builder)
        {
            builder.ToTable("CobrancaEscrituralEspecie");

            builder.HasKey(o => o.ID);
        }
    }
}