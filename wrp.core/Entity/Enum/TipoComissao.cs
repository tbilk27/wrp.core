using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoComissao
    {
        [Display(Name = "Por Quantidade")]
        QUANTIDADE = 0,
        [Display(Name = "Por Margem de Contribuição")]
        MARGEM_CONTRIBUICAO = 1
    }
}
