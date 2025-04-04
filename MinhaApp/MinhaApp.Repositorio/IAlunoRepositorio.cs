using MinhaApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Salvar(Aluno aluno);
        IEnumerable<Aluno> Listar();
    }
}
