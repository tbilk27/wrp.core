using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum FinalidadeEmissaoNFe
    {
        [Display(Name = "NF-e normal")]
        Normal = 1,
        [Display(Name = "NF-e complementar")]
        Complementar = 2,
        [Display(Name = "NF-e de ajuste")]
        Ajuste = 3,
    }
}
