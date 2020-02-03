using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wrp.core.Entity.Proform
{
    public class BaseEmpresa : BaseEntity
    {
        [ForeignKey("IDEmpresa")]
        public Empresa Empresa { get; set; }
        [Index]
        public string IDEmpresa { get; set; }
    }
}
