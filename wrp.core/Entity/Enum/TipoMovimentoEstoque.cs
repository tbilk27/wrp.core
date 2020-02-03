using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoMovimentoEstoque
    {
        Entrada = 1,

        [Display(Name = "Saída")]
        Saida = 2
    }
}
