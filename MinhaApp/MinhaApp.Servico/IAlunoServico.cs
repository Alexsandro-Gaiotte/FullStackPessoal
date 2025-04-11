using MinhaApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Servico
{
    public interface IAlunoServico
    {
        void Adicionar(AlunoDto alunoDto);
        IEnumerable<AlunoDto> Listar();
    }
}
