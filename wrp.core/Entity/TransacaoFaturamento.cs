using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("TRANSACAOFATURAMENTO")]
    public class TransacaoFaturamento : BaseFilial
    {
        [StringLength(8)]
        [FilialIndex("UX_TRANSACAOFATURAMENTO1", IsUnique = true, Order = 2)]
        public string Codigo { get; set; }

        [Required]
        public OperacaoTransacaoFaturamento Operacao { get; set; }

        [StringLength(4)]
        public string CFOP { get; set; }

        [StringLength(100)]
        [Required]
        public string Descricao { get; set; }

        [ForeignKey("IDCSTICMS")]
        public CSTICMS CSTICMS { get; set; }
        public string IDCSTICMS { get; set; }

        [ForeignKey("IDCSOSNICMS")]
        public CSOSNICMS CSOSNICMS { get; set; }
        public string IDCSOSNICMS { get; set; }

        [ForeignKey("IDCSTIPI")]
        public CSTIPI CSTIPI { get; set; }
        public string IDCSTIPI { get; set; }

        [ForeignKey("IDCSTPIS")]
        public CSTPIS CSTPIS { get; set; }
        public string IDCSTPIS { get; set; }

        [ForeignKey("IDCSTCOFINS")]
        public CSTCOFINS CSTCOFINS { get; set; }
        public string IDCSTCOFINS { get; set; }

        public bool MovimentaEstoque { get; set; }

        public bool GeraDuplicata { get; set; }

        public bool Servico { get; set; }
    }
}
