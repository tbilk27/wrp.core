using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum ModalidadeFrete
    {
        [Display(Name = "Contratação do Frete por conta do Remetente(CIF)")]
        POR_CONTA_REMETENTE = 0,

        [Display(Name = "Contratação do Frete por conta do destinatário/remetente(FOB)")]
        POR_CONTA_DESTINATARIO = 1,

        [Display(Name = "Contratação do Frete por conta de terceiros")]
        POR_CONTA_TERCEIROS = 2,

        [Display(Name = "Transporte próprio por conta do remetente")]
        PROPRIO_REMETENTE = 3,

        [Display(Name = "Transporte próprio por conta do destinatário")]
        PROPRIO_DESTINATARIO = 4,

        [Display(Name = "Sem Frete")]
        SEM_FRETE = 9
    }
}