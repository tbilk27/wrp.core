using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoInscricaoEstadual
    {
        [Display(Name = "Contribuinte")]
        CONTRIBUINTE = 1,
        [Display(Name = "Contribuinte Isento")]
        CONTRIBUINTE_ISENTO = 2,
        [Display(Name = "Não Contribuinte")]
        NAO_CONTRIBUINTE = 9
    }
}
