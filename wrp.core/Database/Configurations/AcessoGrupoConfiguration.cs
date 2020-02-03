using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class AcessoGrupoConfiguration : IEntityTypeConfiguration<AcessoGrupo>
    {
        public void Configure(EntityTypeBuilder<AcessoGrupo> builder)
        {
            builder.ToTable("AcessoGrupo");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Descricao).HasMaxLength(200).IsRequired();
            builder.HasIndex(o => o.Descricao).IsUnique(true);

            builder.HasMany<Acesso>(o => o.Acessos).WithOne(g => g.AcessoGrupo).HasForeignKey(g => g.IDAcessoGrupo);
        }
    }
}