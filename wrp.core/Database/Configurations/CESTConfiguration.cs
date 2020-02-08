using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CESTConfiguration : BaseConfiguration<CEST>
    {
        public void Configure(EntityTypeBuilder<CEST> builder)
        {
            builder.Property(o => o.Descricao)
                .HasMaxLength(400);
            builder.Property(o => o.Codigo)
                .HasMaxLength(10).IsRequired();
            builder.HasIndex(o => new { o.IDEmpresa, o.Codigo })
                .IsUnique();
            builder.HasMany(c => c.NCMCEST)
                .WithOne(c => c.Cest)
                .HasForeignKey(c => c.IDCEST);
        }
    }
}