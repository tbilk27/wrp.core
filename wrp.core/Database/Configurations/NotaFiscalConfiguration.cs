using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class NotaFiscalConfiguration : BaseConfiguration<NotaFiscal>
    {
        public void Configure(EntityTypeBuilder<NotaFiscal> builder)
        {
            builder.Property(p => p.NumeroNotaFiscal)
                .IsRequired();

            builder.HasIndex(n => n.NumeroNotaFiscal)
                .IsUnique();

            builder.Property(p => p.DataEmissao)
                .IsRequired();

            builder.Property(p => p.DataMovimento)
                .IsRequired();

            builder.Property(p => p.TipoEmissaoNotaFiscal)
                .IsRequired();

            builder.HasIndex(p => p.TipoEmissaoNotaFiscal)
                .IsUnique();

            builder.Property(p => p.Operacao)
                .IsRequired();

            builder.HasOne<Pessoa>()
                .WithMany(p => p.NotasFiscais)
                .HasForeignKey(p => p.IDPessoa)
                .IsRequired();

            builder.HasIndex(p => p.IDPessoa)
                .IsUnique();

            builder.HasOne<SerieDocumentoFiscal>()
                .WithMany(n => n.NotasFiscais)
                .HasForeignKey(n => n.IDSerie)
                .IsRequired();

            builder.HasIndex(p => p.IDSerie)
                .IsUnique();

            builder.Property(p => p.ChaveNFe)
                .HasMaxLength(44);

            builder.Property(p => p.ModalidadeFrete)
                .IsRequired();

            builder.HasOne<Pessoa>()
                .WithMany(n => n.NotasFiscaisTransporte)
                .HasForeignKey(n => n.IDTransportadora);

            builder.HasOne<CondicaoPagamento>()
                .WithMany(c => c.NotasFiscais)
                .HasForeignKey(c => c.IDCondicaoPagamento);

            builder.HasOne<ContaFinanceira>()
                .WithMany(c => c.NotasFiscais)
                .HasForeignKey(c => c.IDContaFinanceira);

            builder.HasOne<ContaBanco>()
                .WithMany(c => c.NotasFiscais)
                .HasForeignKey(c => c.IDContaBanco);

            builder.HasOne<OperacaoFiscal>()
                .WithMany(c => c.NotasFiscais)
                .HasForeignKey(c => c.IDOperacaoFiscal);

        }
    }
}