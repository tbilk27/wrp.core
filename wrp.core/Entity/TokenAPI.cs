using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("TOKENAPI")]
    public class TokenAPI : BaseFilial
    {
        [ForeignKey("IDUsuario")]
        public Usuario Usuario { get; set; }
        public string IDUsuario { get; set; }   
    }
}
