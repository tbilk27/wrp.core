using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wrp.core.Entity.Proform;

namespace wrp.core.Entity
{
    public class Cheque : BaseFilial
    {
        public string Numero { get; set; }

        public ContaBanco ContaBanco { get; set; }
        public string IDContaBanco { get; set; }

        public DateTime Emissao { get; set; }

        public string Nominal { get; set; }

        public decimal Valor { get; set; }

        public bool Cancelado { get; set; }

        public ICollection<MovimentoConta> Movimentos { get; set; }
    }
}
