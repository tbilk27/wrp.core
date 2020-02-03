using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ComissaoFechamentoConfiguration : IEntityTypeConfiguration<ComissaoFechamento>
    {
        public void Configure(EntityTypeBuilder<ComissaoFechamento> builder)
        {
            builder.ToTable("ComissaoFechamento");

            builder.HasKey(o => o.ID);

            builder.HasOne(f => f.Favorecido)
                .WithMany(f => f.ComissoesFechamentos)
                .HasForeignKey(f => f.IDFavorecido)
                .IsRequired();

            builder.HasOne(c => c.RegistroIR)
                .WithMany(c => c.ComissoesFechamentosRegistrosIR)
                .HasForeignKey(c => c.IDRegistroIR);

            builder.HasOne(c => c.RegistroPagto)
                .WithMany(c => c.ComissoesFechamentosRegistrosPagamentos)
                .HasForeignKey(c => c.IDRegistroPagto);

            builder.HasOne(c => c.RegistroTransferencia)
                .WithMany(c => c.ComissoesFechamentosRegistrosTransferencia)
                .HasForeignKey(c => c.IDRegistroTransferencia);

            builder.HasOne(c => c.TituloImposto)
                .WithMany(c => c.ComissoesFechamentoTitulosImpostos)
                .HasForeignKey(c => c.IDTituloImposto);

            builder.HasOne(c => c.TituloPagto)
                .WithMany(c => c.ComissoesFechamentoTitulosPagamentos)
                .HasForeignKey(c => c.IDTituloPagto);
        }
    }
}
}