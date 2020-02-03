using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("SEFAZBUSCA")]
    public class SefazBusca : BaseFilial
    {
        public DateTime? UltimaConsulta { get; set; }
        
        [StringLength(20)]
        public string NSU { get; set; } = "0";

        public bool ManifestarCiencia { get; set; }

        [ForeignKey("IDCertificado")]
        public CertificadoDigital Certificado {get; set; }
        public string IDCertificado { get; set; }
    }
}
