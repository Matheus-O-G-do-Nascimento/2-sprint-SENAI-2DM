using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {

        public int idJogo { get; set; }

        public int idEstudio { get; set; }

        public string nomeJogo { get; set; }

        public string descricaoJogo { get; set; }

        public DateTime dataLancamento { get; set; }

        public int valorJogo { get; set; }
    }
}
