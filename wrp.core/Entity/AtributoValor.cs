using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class AtributoValor : BaseEntity
    {
        public Atributo Atributo { get; set; }
        public string IDAtributo { get; set; }

        public string Descricao { get; set; }
    }
}