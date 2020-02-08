using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class MarcaProdutoConfiguration : BaseConfiguration<MarcaProduto>
    {
        public void Configure(EntityTypeBuilder<Local> builder)
        {
            builder.Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}