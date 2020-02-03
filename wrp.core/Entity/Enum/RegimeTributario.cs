using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum RegimeTributario
    {
        [Display(Name = "Simples Nacional")]
        SimplesNacional = 0,
        [Display(Name = "Lucro Presumido")]
        LucroPresumido = 1,
        [Display(Name = "Lucro Real")]
        LucroReal = 2
    }
}
