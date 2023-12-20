using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProff.Models
{
    public class AvaliacaoModel
    {
        public int IdAvaliacao { get; set; }
        public string ? TipoAvaliacao { get; set; } 
        public DateTime ? DataAvaliacao { get; set; }
        public DisciplinaModel ? IdDisciplina { get; set; }
    }
}
