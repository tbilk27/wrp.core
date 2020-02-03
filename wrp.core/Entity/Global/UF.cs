using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity.Global
{
    [Table("UF")]
    public class UF : BaseEntity
    {
        [ForeignKey("IDPais")]
        public Pais Pais { get; set; }
        [Required]
        public string IDPais { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(2)]
        public string Sigla { get; set; }

        public int Codigo { get; set; }

        [ForeignKey("IDUF")]
        public virtual ICollection<UFDefinicao> UFDefinicao { get; set; }
    }
}
