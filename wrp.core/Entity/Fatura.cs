using System.Collections.Generic;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Fatura. Por enquando com poucas propriedades.
    /// </summary>
    public class Fatura : BaseFilial
    {
        /// <summary>
        /// Número da fatura
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Série da fatura
        /// </summary>
        public string Serie { get; set; }

        /// <summary>
        /// Modelo da fatura
        /// </summary>
        public string Modelo { get; set; }

        public ICollection<FaturaTitulo> FaturasTitulos { get; set; }
    }
}