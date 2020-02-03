using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wrp.core.Entity.Proform
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        [StringLength(36)]
        public string ID { get; set; }

        public DateTime DataCriacao { get; set; }

        [ForeignKey("IDUsuarioCriacao")]
        public Usuario UsuarioCriacao { get; set; }
        [StringLength(36)]
        public string IDUsuarioCriacao { get; set; }

        public BaseEntity()
        {
            ID = Guid.NewGuid().ToString();
        }
    }
}
