using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrp.core.Entity.Enum
{
    public enum StatusPedido
    {
        Digitação = 0,  // recém digitado ou importado
        Análise = 1,    // em análise
        Liberado = 2,   // liberado
        Atendimento = 3,// em atendimento
        Atendido = 4,   // atendido
        Faturamento = 5,// em faturamento
        Faturado = 6,   // faturado
        Enviado = 7     // despachado 
    }
}
