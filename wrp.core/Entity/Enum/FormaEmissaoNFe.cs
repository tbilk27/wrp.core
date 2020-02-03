
using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum FormaEmissaoNFe
    {
        [Display(Name = "Normal")]
        Normal = 1,
        [Display(Name = "Contingência FS")]
        FS = 2,
        [Display(Name = "Contingência SCAN")]
        SCAN = 3,
        [Display(Name = "Contingência DPEC")]
        DPEC = 4,
        [Display(Name = "Contingência FSDA")]
        FSDA = 5,
        [Display(Name = "Contingência SVC - AN")]
        SVC_AN = 6,
        [Display(Name = "Contingência SVC - RS")]
        SVC_RS = 7,
        [Display(Name = "Contingência off-line NFC-e")]
        OFFLINE_NFCe = 9,
    }
}
