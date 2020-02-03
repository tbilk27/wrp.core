using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum SituacaoNotaFiscal
    {
        [Display(Name = "Pendente")]
        Pendente = 0,

        [Display(Name = "Autorizada")]
        Autorizada = 1,

        [Display(Name = "Cancelada")]
        Cancelada = 2
    }
}
