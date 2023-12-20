using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProff.Models
{
    public class PeriodoLetivoModel
    {
        public int IdPeriodoLetivo { get; set; }
        public DateTime DataInicioPL { get; set; }
        public DateTime DataFimPL { get; set; }
        public bool AtivoPL { get; set; }

    }
}
