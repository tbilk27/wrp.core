using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("TITULO")]
    public class Titulo : BaseFilial
    {
        [ForeignKey("IDTipoTitulo")]
        public TipoTitulo TipoTitulo { get; set; }
        [Required]
        [FilialIndex("UX_TITULO1", IsUnique = true, Order = 2)]
        public string IDTipoTitulo { get; set; }

        [StringLength(20)]
        [FilialIndex("UX_TITULO1", IsUnique = true, Order = 3)]
        public string NumeroTitulo { get; set; }

        [ForeignKey("IDSacado")]
        public Pessoa Sacado { get; set; }
        [Required]
        [FilialIndex("UX_TITULO1", IsUnique = true, Order = 4)]
        public string IDSacado { get; set; }

        [ForeignKey("IDFavorecido")]
        public Pessoa Favorecido { get; set; }
        [Required]
        [FilialIndex("UX_TITULO1", IsUnique = true, Order = 5)]
        public string IDFavorecido { get; set; }

        [ForeignKey("IDContaBanco")]
        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        public DateTime Emissao { get; set; }

        public decimal Valor { get; set; }

        public DateTime Vencimento { get; set; }

        public StatusTitulo StatusTitulo { get; set; }

        public ModuloTitulo ModuloTitulo { get; set; }

        public decimal Saldo { get; set; }

        [ForeignKey("IDTitulo")]
        public virtual ICollection<MovimentoTitulo> Movimentos { get; set; }

        [ForeignKey("IDContaFinanceira")]
        public ContaFinanceira ContaFinanceira { get; set; }

        [Required]
        public string IDContaFinanceira { get; set; }

        [StringLength(40)]
        public string NumeroCheque { get; set; }

        [StringLength(400)]
        public string Historico { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal PercentualJurosDia { get; set; }

        [DataTypeDecimal(4, 2)]
        public decimal PercentualMulta { get; set; }

        public ICollection<Comissao> Comissoes { get; set; }

        public ICollection<ComissaoFechamento> ComissoesFechamentoTitulosImpostos { get; set; }
        public ICollection<ComissaoFechamento> ComissoesFechamentoTitulosPagamentos { get; set; }

        public ICollection<FaturaTitulo> FaturasTitulos { get; set; }

    }
}
