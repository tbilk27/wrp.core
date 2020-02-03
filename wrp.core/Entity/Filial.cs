using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("FILIAL")]
    public class Filial : BaseEmpresa
    {
        [ForeignKey("IDPessoa")]
        public Pessoa Pessoa { get; set; }
        public string IDPessoa { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        public bool Matriz { get; set; }
        public bool IntegraMeusPedidos { get; set; }
        public decimal BaseIRMinimaRecolhimentoComissao { get; set; }
        public decimal AliquotaIRComissao { get; set; }

        public bool EmiteNFSe { get; set; }
        public bool EmiteNFe { get; set; }

        public RegimeTributario RegimeTributario { get; set; }

        public virtual ICollection<SefazBusca> SefazBusca { get; set; }

    }
}
