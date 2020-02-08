using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class MovimentoContaConfiguration : BaseConfiguration<MovimentoConta>
    {
        public void Configure(EntityTypeBuilder<MovimentoConta> builder)
        {
            builder.HasOne<ContaBanco>()
                .WithMany(c => c.Movimentos)
                .HasForeignKey(c => c.IDContaBanco)
                .IsRequired();

            builder.HasOne<MovimentoTitulo>()
                .WithMany(c => c.Movimentos)
                .HasForeignKey(c => c.IDMovimentoTitulo);

            builder.Property(m => m.TipoMovimentoConta)
                .IsRequired();

            builder.Property(p => p.Referencia)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Historico)
                .HasMaxLength(200);

            builder.Property(p => p.DataMovimento)
                .IsRequired();

            builder.HasOne<ContaFinanceira>()
                .WithMany(c => c.Movimentos)
                .HasForeignKey(c => c.IDContaFinanceira)
                .IsRequired();

            builder.HasOne<MovimentoConta>()
                .WithMany(m => m.MovimentosTransferencias)
                .HasForeignKey(m => m.IDMovimentoContaTransferencia);

            builder.HasOne<Cheque>()
                .WithMany(c => c.Movimentos)
                .HasForeignKey(c => c.IDCheque);
        }
    }
}