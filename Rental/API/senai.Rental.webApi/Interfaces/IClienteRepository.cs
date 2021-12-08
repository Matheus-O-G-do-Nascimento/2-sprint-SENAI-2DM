using Rental.Domains;
using Rental.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Interfaces
{
    interface IClienteRepository
    {

        public List<ClienteDomain> Listar();

        public ClienteDomain BuscarPorId(int id);

        public void Inserir(ClienteDomain Cliente);

        public void Deletar(int id);

        public void Atualizar(int id, ClienteDomain clienteAtualizado);

    }
}
