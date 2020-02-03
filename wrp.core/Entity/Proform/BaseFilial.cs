using System.ComponentModel.DataAnnotations.Schema;

namespace wrp.core.Entity.Proform
{
    public class BaseFilial : BaseEmpresa
    {
        [ForeignKey("IDFilial")]
        public Filial Filial { get; set; }
        [Index]
        public string IDFilial { get; set; }
    }
}
