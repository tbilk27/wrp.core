using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class ModeloDocumentoFiscal : BaseEmpresa
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public bool Servico { get; set; }
    }
}