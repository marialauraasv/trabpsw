using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SistemaBiblioteca.Controllers
{
    [ApiController]
    [Route("api/livros")]
    public class LivrosController : ControllerBase
    {
        private LivroRepository livroRepository = new LivroRepository();

        [HttpGet("consulta")]
        public IActionResult ConsultarLivros([FromQuery] string filtro)
        {
            List<string> livros = livroRepository.ConsultarLivros(filtro);
            return Ok(livros);
        }
    }
}
