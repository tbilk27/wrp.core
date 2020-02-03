using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoMovimentoComissao
    {
        [Display(Name = "Crédito")]
        Credito = 1,

        [Display(Name = "Débito")]
        Debito = 2
    }
}
