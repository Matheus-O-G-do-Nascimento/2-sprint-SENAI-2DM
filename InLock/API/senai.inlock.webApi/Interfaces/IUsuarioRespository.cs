using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Interfaces
{
    interface IUsuarioRespository
    {

        public List<UsuarioDomain> Listar();

        public UsuarioDomain BuscarPorId(int id);

        public void Inserir(UsuarioDomain usuario);

        public void Deletar(int id);

        public void Atualizar(int id, UsuarioDomain usuarioAtualizado);
    }
}
