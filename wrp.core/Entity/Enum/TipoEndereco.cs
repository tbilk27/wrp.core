using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoEndereco
    {
        Comercial = 0,
        [Display(Name = "Cobrança")]
        Cobranca = 1,
        Entrega = 2,
        Residencial = 3
    }
}
