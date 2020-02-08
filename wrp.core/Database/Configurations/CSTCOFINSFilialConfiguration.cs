using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTCOFINSFilialConfiguration : IEntityTypeConfiguration<CSTCOFINSFilial>
    {
        public void Configure(EntityTypeBuilder<CSTCOFINSFilial> builder)
        {
            builder.ToTable("CSTCOFINSFilial");

            builder.HasKey(o => o.ID);

            builder.HasOne(c => c.CSTCOFINS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTCOFINS);

            builder.HasIndex(c => c.IDCSTCOFINS)
                .IsUnique();
        }
    }
}