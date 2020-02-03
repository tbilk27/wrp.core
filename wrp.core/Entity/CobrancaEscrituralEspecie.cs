using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CobrancaEscrituralEspecie : BaseFilial
    {
        public Banco Banco { get; set; }
        public string IDBanco { get; set; }

        public TipoTitulo TipoTitulo { get; set; }
        public string IDTipoTitulo { get; set; }

        public int Especie { get; set; }
    }
}