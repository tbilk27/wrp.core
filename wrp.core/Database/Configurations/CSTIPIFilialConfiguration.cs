using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTIPIFilialConfiguration : BaseConfiguration<CSTIPIFilial>
    {
        public void Configure(EntityTypeBuilder<CSTIPIFilial> builder)
        {
            builder.HasOne(c => c.CSTIPI)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTIPI);

            builder.HasIndex(c => c.IDCSTIPI)
                .IsUnique();
        }
    }
}