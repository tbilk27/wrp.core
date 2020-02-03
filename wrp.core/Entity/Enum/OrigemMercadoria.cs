using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum OrigemMercadoria
    {
        [Display(Name = "0 - Nacional, exceto as indicadas nos códigos 3, 4, 5 e 8")]
        NACIONAL = 0,
        [Display(Name = "1 - Estrangeira - Importação direta, exceto a indicada no código 6")]
        ESTRANGEIRA_IMPORTACAO_DIRETA = 1,
        [Display(Name = "2 - Estrangeira - Adquirida no mercado interno, exceto a indicada no código 7")]
        ESTRANGEIRA_MERC_INTERNO = 2,
        [Display(Name = "3 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quarenta por cento) e inferior ou igual a 70% (setenta por cento)")]
        NACIONAL_SUPERIOR_40 = 3,
        [Display(Name = "4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam o Decreto-Lei nº 288/67, e as Leis nºs 8.248/91, 8.387/91, 10.176/01 e 11.484/07")]
        NACIONAL_PROC_PRODUTIVO = 4,
        [Display(Name = "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40% (quarenta por cento)")]
        NACIONAL_INFERIOR_40 = 5,
        [Display(Name = "6 - Estrangeira - Importação direta, sem similar nacional, constante em lista de Resolução CAMEX e gás natural")]
        EXTRANGEIRA_IMPORTACAO_CAMEX = 6,
        [Display(Name = "7 - Estrangeira - Adquirida no mercado interno, sem similar nacional, constante em lista de Resolução CAMEX e gás natural")]
        EXTRANGEIRA_MERC_INTERNO_CAMEX = 7,
        [Display(Name = "8 - Nacional, mercadoria ou bem com Conteúdo de Importação superior a 70% (setenta por cento)")]
        NACIONAL_SUPERIOR_70 = 8
    }
}
