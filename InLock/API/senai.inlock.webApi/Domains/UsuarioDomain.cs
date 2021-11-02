using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    public class UsuarioDomain
    {

        public int idUsuario { get; set; }

        public int idTipoUsuario { get; set; }

        public string emailUsuario { get; set; }

        private string senhaUsuario { get; set; }

    }
}
