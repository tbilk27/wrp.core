using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoAmbienteNFe
    {
        [Display(Name = "Produção")]
        Producao = 1,
        [Display(Name = "Homologação")]
        Homologação = 2,
    }
}
