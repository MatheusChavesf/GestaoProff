using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProff.Models
{
    public class CertificadoModel
    {
        public int IdCertificado { get; set; }
        public AlunoModel ? MatriculaAluno { get; set; }
        public CursoModel ? IdCurso { get; set; }
        public DateTime ? DataCertificado { get; set; }
    }
}
