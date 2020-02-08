using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CEST : BaseEmpresa
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<NCMCEST> NCMCESTs { get; set; }
    }
}
