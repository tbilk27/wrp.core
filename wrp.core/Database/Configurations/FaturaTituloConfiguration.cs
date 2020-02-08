using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FaturaTituloConfiguration : BaseConfiguration<FaturaTitulo>
    {
        public void Configure(EntityTypeBuilder<FaturaTitulo> builder)
        {
            builder.HasOne(f => f.Fatura)
                .WithMany(f => f.FaturasTitulos)
                .HasForeignKey(f => f.IDFatura)
                .IsRequired();

            builder.HasOne(f => f.Titulo)
                .WithMany(f => f.FaturasTitulos)
                .HasForeignKey(f => f.IDTitulo);
        }
    }
}