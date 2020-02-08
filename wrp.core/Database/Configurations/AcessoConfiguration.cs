using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class AcessoConfiguration : BaseConfiguration<Acesso>
    {
        public void Configure(EntityTypeBuilder<Acesso> builder)
        {
            builder.Property(o => o.Descricao).HasMaxLength(200).IsRequired();
            builder.Property(o => o.CodigoOperacao).HasMaxLength(100).IsRequired();
            builder.HasIndex(o => o.CodigoOperacao).IsUnique(true);
            builder.HasOne(o => o.AcessoGrupo)
                .WithMany(g => g.Acessos)
                .HasForeignKey(g => g.IDAcessoGrupo);
        }
    }
}