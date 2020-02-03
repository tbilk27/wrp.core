using System.ComponentModel.DataAnnotations;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CobrancaEscritural : BaseFilial
    {
        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        public int Cedente { get; set; }

        public TipoEmissaoCobrancaEscritural TipoEmissao { get; set; }

        public TipoDistribuicaoCobrancaEscritural TipoDistribuicao { get; set; }

        public TipoJuros TipoJuros { get; set; }

        public TipoMulta TipoMulta { get; set; }

        public int Modalidade { get; set; }

        [StringLength(2)]
        public string Carteira { get; set; }

        public bool RequerAceite { get; set; }
    }
}