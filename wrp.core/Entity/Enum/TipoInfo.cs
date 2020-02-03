using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoInfo
    {
        [Display(Name = "Informação")]
        Informacao = 0,
        [Display(Name = "Restrição")]
        Restricao = 1,
        Bloqueio = 2
    }
}
