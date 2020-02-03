using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    [Table("TABELAPRECO")]
    public class TabelaPreco : BaseFilial
    {
        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public bool Ativa { get; set; }

        public bool Promocional { get; set; }

        public DateTime? InicioValidade { get; set; }

        public DateTime? FimValidade { get; set; }

        public bool Dinamica { get; set; }

    }
}
