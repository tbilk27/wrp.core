using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("SEFAZXML")]
    public class SefazXML : BaseFilial
    {
        [Index]
        [StringLength(44)]
        public string Chave { get; set; }

        [Index]
        [StringLength(30)]
        public string Schema { get; set; }

        public string Conteudo { get; set; }

        [StringLength(20)]
        [Index("UX_NSU", 2, IsUnique = true)]
        public string NSU { get; set; }
        
        [ForeignKey("IDBusca")]
        public SefazBusca Busca { get; set; }
        [Required]
        [Index("UX_NSU", 1 , IsUnique = true)]
        public string IDBusca { get; set; }

        /// <summary>
        /// Quando for um resumo de NFe, esse campo indica se já foi feito o manifesto de ciência da emissão.
        /// Usado para indicar quando precisa fazer o manifesto de ciência, mas não quer dizer que se está true foi o sistema que fez o manifesto.
        /// </summary>
        [Index]
        public bool Manifestado { get; set; }
    }
}
