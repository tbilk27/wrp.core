using System;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class CertificadoDigital : BaseFilial
    {
        public string Descricao { get; set; }

        public DateTime DataFim { get; set; }

        public DateTime DataInicio { get; set; }

        public string Caminho { get; set; }

        public string Senha { get; set; }
    }
}