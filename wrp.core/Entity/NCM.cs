using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class NCM : BaseEmpresa
    {
        [Range(0, 99999999)]
        public int CodigoNCM { get; set; }

        public string Descricao { get; set; }

        public decimal AliquotaIPI { get; set; }

        public virtual ICollection<NCMCEST> NCMCEST { get; set; }
    }
}