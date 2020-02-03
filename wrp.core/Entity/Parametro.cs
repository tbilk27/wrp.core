using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using wrp.core.Entity.Enum;
using wrp.core.Entity.Proform;
using wrp.core.Infrastructure.Filters;

namespace wrp.core.Entity
{
    [Table("PARAMETRO")]
    public class Parametro : BaseFilial
    {
        [Required]
        [StringLength(100)]
        [FilialIndex("UX_Parametro1",1, IsUnique = true)]
        public string Nome { get; set; }

        [Required]
        [FilialIndex("UX_Parametro1",2, IsUnique = true)]
        public ParametroCategoria Categoria { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }

        /// <summary>
        /// Usado para validar o campo, se conseguir fazer um parse, o campo é válido. Exemplo parametro.Tipo = typeof(int).ToString()
        /// </summary>
        [StringLength(100)]
        public string Tipo { get; set; }

        [StringLength(1000)]
        public string Valor { get; set; }

        public bool Senha { get; set; }
    }
}
