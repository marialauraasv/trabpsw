using Microsoft.AspNetCore.Mvc;

namespace Sistema
{
    // Supondo que você tenha uma classe chamada UsuarioRepository com o método ObterTodosUsuarios
    public class UsuarioRepository
    {
        public object ObterTodosUsuarios()
        {
            // Lógica para obter os usuários
            return new[] { "Usuario1", "Usuario2" }; // Exemplo de retorno
        }
    }

    internal class Program
    {
        // Repositório de usuários
        private static UsuarioRepository usuarioRepository = new UsuarioRepository();

        [HttpGet]
        private static IActionResult ObterUsuarios()
        {
            var usuarios = usuarioRepository.ObterTodosUsuarios(); // Método no repositório
            return Ok(usuarios);
        }

        private static IActionResult Ok(object usuarios)
        {
            // Retornar um resultado adequado, em um cenário real, pode ser um retorno de HTTP
            return new JsonResult(usuarios); // Retorna uma resposta JSON com os usuários
        }

        static void Main(string[] args)
        {
            // Sua lógica de inicialização
        }
    }
}
