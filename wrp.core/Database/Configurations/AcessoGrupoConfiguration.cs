using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class AcessoGrupoConfiguration : BaseConfiguration<AcessoGrupo>
    {
        public void Configure(EntityTypeBuilder<AcessoGrupo> builder)
        {
            builder.Property(o => o.Descricao)
                .HasMaxLength(200)
                .IsRequired();
            builder.HasIndex(o => o.Descricao)
                .IsUnique(true);
            builder.HasMany<Acesso>(o => o.Acessos)
                .WithOne(g => g.AcessoGrupo)
                .HasForeignKey(g => g.IDAcessoGrupo);
        }
    }
}