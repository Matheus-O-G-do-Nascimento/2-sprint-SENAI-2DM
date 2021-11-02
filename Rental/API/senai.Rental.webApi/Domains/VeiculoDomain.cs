using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Domains
{
    public class VeiculoDomain
    {
        
        public int idVeiculo { get; set; }

        private int placaVeiculo { get; set; }


        public int idModelo { get; set; }

        public int idMarca { get; set; }

        public int idEmpresa { get; set; }
    }
}
