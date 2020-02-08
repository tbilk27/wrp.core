using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FormulaBaseCalculoConfiguration : BaseConfiguration<FormulaBaseCalculo>
    {
        public void Configure(EntityTypeBuilder<FormulaBaseCalculo> builder)
        {
            builder.Property(p => p.Descricao)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Formula)
                .HasMaxLength(500);
        }
    }
}