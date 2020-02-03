using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum OperacaoTransacaoFaturamento
    {
        Entrada = 1,

        [Display(Name = "Saída")]
        Saida = 2
    }
}
