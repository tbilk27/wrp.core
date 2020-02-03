using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum DestinoOperacaoFaturamento
    {
        [Display(Name = "Operação Interna")]
        Interna = 0,
        [Display(Name = "Operação Interestadual")]
        Interestadual = 1,
        [Display(Name = "Operação com Exterior")]
        Exterior = 2,
    }
}
