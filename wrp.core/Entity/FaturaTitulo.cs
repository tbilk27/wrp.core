using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class FaturaTitulo : BaseEntity
    {
        public Fatura Fatura { get; set; }
        public string IDFatura { get; set; }
        public Titulo Titulo { get; set; }
        public string IDTitulo { get; set; }
    }
}