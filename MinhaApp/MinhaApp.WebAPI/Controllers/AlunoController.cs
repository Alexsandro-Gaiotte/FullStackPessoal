using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaApp.Servico;

namespace MinhaApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _servico;
        public AlunoController(IAlunoServico servico)
        {
            _servico = servico;
        }
        [HttpPost]
        public IActionResult Adicionar(AlunoDto dto) 
        {
            _servico.Adicionar(dto);
            return Ok("Aluno adicionado com sucesso");
        }
        [HttpGet]
        public IActionResult Listar() 
        {
            return Ok(_servico.Listar());
        }
    }
}
