using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FilialTributosFederaisServicosConfiguration : BaseConfiguration<FilialTributosFederaisServicos>
    {
        public void Configure(EntityTypeBuilder<FilialTributosFederaisServicos> builder)
        {
            builder.Property(c => c.AliquotaPIS)
                .HasColumnType("decimal(4,2");

            builder.Property(c => c.AliquotaCofins)
                .HasColumnType("decimal(4,2");

            builder.Property(c => c.AliquotaINSS)
                .HasColumnType("decimal(4,2");

            builder.Property(c => c.AliquotaIR)
                .HasColumnType("decimal(4,2");

            builder.Property(c => c.AliquotaCSLL)
                .HasColumnType("decimal(4,2");

            builder.Property(c => c.AliquotaPS)
                .HasColumnType("decimal(4,2");
        }
    }
}