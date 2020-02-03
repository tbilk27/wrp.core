using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoMulta
    {
        Isento = 0,
        [Display(Name = "Valor Fixo")]
        ValorFixo = 1,
        [Display(Name = "Percentual")]
        Percentual = 2
    }
}
