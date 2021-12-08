using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rental.Domains;
using Rental.Repositories;

namespace Rental.Interfaces
{
    interface IAluguelRepository
    {
        public List<AluguelDomain> Listar();

        public AluguelDomain BuscarPorId(int id);

        public void Inserir(AluguelDomain aluguel);

        public void Deletar(int id);

        public void Atualizar(int id, AluguelDomain aluguelAtualizado);
    }
}
