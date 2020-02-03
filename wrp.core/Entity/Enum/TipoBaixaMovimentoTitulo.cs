using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoBaixaMovimentoTitulo
    {
        [Display(Name = "Pagamento")]
        Pagamento = 0,
        [Display(Name = "Substituição")]
        Substituicao = 1
    }
}
