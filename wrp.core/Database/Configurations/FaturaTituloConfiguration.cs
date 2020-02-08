using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FaturaTituloConfiguration : IEntityTypeConfiguration<FaturaTitulo>
    {
        public void Configure(EntityTypeBuilder<FaturaTitulo> builder)
        {
            builder.ToTable("FaturaTitulo");

            builder.HasKey(o => o.ID);

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