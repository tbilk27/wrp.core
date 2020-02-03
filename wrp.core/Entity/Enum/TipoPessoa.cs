using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoPessoa
    {
        [Display(Name = "Física")]
        Fisica = 'F',
        [Display(Name = "Jurídica")]
        Juridica = 'J'
    }
}
