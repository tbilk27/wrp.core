using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ComissaoConfiguration : BaseConfiguration<Comissao>
    {
        public void Configure(EntityTypeBuilder<Comissao> builder)
        {
            builder.HasOne(f => f.Favorecido)
                .WithMany(p => p.Comissoes)
                .HasForeignKey(p => p.IDFavorecido)
                .IsRequired();

            builder.HasOne(t => t.Titulo)
                .WithMany(t => t.Comissoes)
                .HasForeignKey(t => t.IDTitulo);

            builder.HasOne(m => m.MovimentoTitulo)
                .WithMany(m => m.Comissoes)
                .HasForeignKey(m => m.IDMovimentoTitulo);

            builder.HasOne(c => c.ComissaoFechamento)
                .WithMany(c => c.Comissoes)
                .HasForeignKey(c => c.IDComissaoFechamento);
        }
    }
}