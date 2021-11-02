using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Repositories;

namespace senai.inlock.webApi.Interfaces
{
    interface IJogoRepository
    {

        public List<JogoDomain> Listar();

        public JogoDomain BuscarPorId(int id);

        public void Inserir(JogoDomain jogo);

        public void Deletar(int id);

        public void Atualizar(int id, JogoDomain jogoAtualizado);
    }
}
