using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoJuros
    {
        Isento = 0,
        [Display(Name = "Valor por dia")]
        ValorDia = 1,
        [Display(Name = "Taxa Mensal")]
        TaxaMensal = 2
    }
}
