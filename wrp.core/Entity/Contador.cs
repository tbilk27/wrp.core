using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    /// <summary>
    /// Tabela de contadores
    /// </summary>
    public class Contador : BaseFilial
    {
        public string Nome { get; set; }

        public long Valor { get; set; }
    }
}