using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Arquivo : BaseEntity
    {
        public string Nome { get; set; }

        public string Mime { get; set; }

        public string Extensao { get; set; }
    }
}