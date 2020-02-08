using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ContaFinanceiraConfiguration : IEntityTypeConfiguration<ContaFinanceira>
    {
        public void Configure(EntityTypeBuilder<ContaFinanceira> builder)
        {
            builder.ToTable("ContaFinanceira");

            builder.HasKey(o => o.ID);

            builder.Property(p => p.Descricao)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.TipoContaFinanceira)
                .IsRequired();

            builder.HasOne(c => c.PlanoContas)
                .WithMany(c => c.ContasFinanceiras)
                .HasForeignKey(c => c.IDPlanoContas)
                .IsRequired();

            builder.HasMany(c => c.ListaContasFilhas)
                .WithOne(c => c.ContaFinanceiraAnalitica)
                .HasForeignKey(c => c.IDContaFinanceiraAnalitica);
        }
    }
}