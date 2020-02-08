using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTCOFINSFilialConfiguration : BaseConfiguration<CSTCOFINSFilial>
    {
        public void Configure(EntityTypeBuilder<CSTCOFINSFilial> builder)
        {
            builder.HasOne(c => c.CSTCOFINS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTCOFINS);

            builder.HasIndex(c => c.IDCSTCOFINS)
                .IsUnique();
        }
    }
}