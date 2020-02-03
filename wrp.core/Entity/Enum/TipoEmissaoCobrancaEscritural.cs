using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoEmissaoCobrancaEscritural
    {
        [Display(Name = "Banco Emite")]
        BancoEmite = 1,
        [Display(Name = "Beneficiário Emite")]
        BeneficiarioEmite = 2
    }
}
