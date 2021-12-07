using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Domains
{
    public class ClienteDomain
    {

        public int idCliente { get; set; }

        public string nomeCliente { get; set; }

        private string cpfCliente { get; set; }
    }
}
