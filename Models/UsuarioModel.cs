﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoProff.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public string ? NomeUsuario { get; set; }        
        public string ? SenhaUsuario { get; set; }
        public string ? TipoUsuario { get; set; } 
    }
}
