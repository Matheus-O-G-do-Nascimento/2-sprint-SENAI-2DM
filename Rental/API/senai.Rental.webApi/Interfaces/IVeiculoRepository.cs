using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rental.Domains;
using Rental.Repositories;

namespace Rental.Interfaces
{
    interface IVeiculoRepository
    {

        public List<VeiculoDomain> Listar();

        public VeiculoDomain BuscarPorId(int id);

        public void Inserir(VeiculoDomain veiculo);

        public void Deletar(int id);

        public void Atualizar(int id, VeiculoDomain veiculoAtualizado);

    }
}
