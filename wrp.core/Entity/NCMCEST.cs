using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Relacionamento entre NCM e CEST
    /// </summary>
    public class NCMCEST : BaseEntity
    {
        public NCM NCM { get; set; }

        public string IDNCM { get; set; }

        public CEST Cest { get; set; }

        public string IDCEST { get; set; }
    }
}