using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Interfaces
{
    interface IEstudioRespository
    {

        public List<EstudioDomain> Listar();

        public EstudioDomain BuscarPorId(int id);

        public void Inserir(EstudioDomain estudio);

        public void Deletar(int id);

        public void Atualizar(int id, EstudioDomain estudioAtualizado);

    }
}
