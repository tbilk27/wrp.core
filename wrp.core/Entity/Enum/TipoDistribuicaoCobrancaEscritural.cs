using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoDistribuicaoCobrancaEscritural
    {
        [Display(Name = "Banco Distribui")]
        BancoEmite = 1,
        [Display(Name = "Beneficiário Distribui")]
        BeneficiarioDistribui = 2
    }
}
