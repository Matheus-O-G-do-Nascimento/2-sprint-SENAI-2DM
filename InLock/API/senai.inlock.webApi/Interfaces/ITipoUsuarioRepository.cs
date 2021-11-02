using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Interfaces
{
    interface ITipoUsuarioRepository
    {

        public List<TipoUsuarioDomain> Listar();

        public TipoUsuarioDomain BuscarPorId(int id);

        public void Inserir(TipoUsuarioDomain tipoUsuario);

        public void Deletar(int id);

        public void Atualizar(int id, TipoUsuarioDomain tipoUsuarioAtualizado);
    }
}
