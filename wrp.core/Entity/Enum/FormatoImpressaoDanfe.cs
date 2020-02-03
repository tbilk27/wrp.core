using System.ComponentModel.DataAnnotations;


namespace wrp.core.Entity.Enum
{
    public enum FormatoImpressaoDanfe
    {
        [Display(Name = "Sem DANFE")]
        SEM_DANFE = 0,
        [Display(Name = "DANFe Retrato")]
        DANFE_RETRATO = 1,
        [Display(Name = "DANFe Paisagem")]
        DANFE_PAISAGEM = 2,
        [Display(Name = "DANFe Simplificado")]
        DANFE_SIMPLIFICADO = 3,
        [Display(Name = "DANFe FC-e")]
        DANFE_FC_e = 4,
        [Display(Name = "DANFe NFC-e em mensagem eletrônica")]
        DANFE_NFC_e = 4,
    }
}
