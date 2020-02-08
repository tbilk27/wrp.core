using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Local : BaseFilial
    {
        public Armazem Armazem { get; set; }
        public string IDArmazem { get; set; }

        public string Descricao { get; set; }

        public bool PadraoEntradaNotaFiscal { get; set; }

        public int Sequencia { get; set; }

        public ICollection<Etiqueta> Etiquetas { get; set; }
    }
}