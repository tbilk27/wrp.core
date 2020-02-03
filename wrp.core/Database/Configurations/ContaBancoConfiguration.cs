using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ContaBancoConfiguration : IEntityTypeConfiguration<ContaBanco>
    {
        public void Configure(EntityTypeBuilder<ContaBanco> builder)
        {
            builder.ToTable("ContaBanco");

            builder.HasKey(o => o.ID);

            builder.HasOne(b => b.Banco)
                .WithMany(b => b.Contas)
                .HasForeignKey(b => b.IDBanco)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Agencia)
                .HasMaxLength(7);

            builder.Property(p => p.DvAgencia)
                .HasMaxLength(2);

            builder.Property(p => p.Conta)
                .HasMaxLength(14);

            builder.Property(p => p.DvConta)
                .HasMaxLength(2);
        }
    }
}