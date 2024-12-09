using System;
using System.Data.SqlClient;

public class LivroRepository  // Aqui começa a classe
{
    // String de conexão com o banco de dados
    private string connectionString = "Server=SEU_SERVIDOR;Database=SistemaBiblioteca;Integrated Security=True;"; // Substitua com suas informações do banco

    // Método para registrar um empréstimo de livro
    public void RegistrarEmprestimo(int livroId, int usuarioId, DateTime dataEmprestimo, DateTime dataDevolucaoPrevista)
    {
        // A query SQL para inserir o empréstimo na tabela Emprestimos
        string query = "INSERT INTO Emprestimos (LivroId, UsuarioId, DataEmprestimo, DataDevolucaoPrevista) " +
                       "VALUES (@LivroId, @UsuarioId, @DataEmprestimo, @DataDevolucaoPrevista)";

        // Conectando ao banco de dados e executando o comando SQL
        using (SqlConnection conn = new SqlConnection(connectionString))  // Abre a conexão
        {
            try
            {
                // Abre a conexão com o banco
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))  // Comando que será executado
                {
                    // Substitui os parâmetros da query pelos valores passados ao método
                    cmd.Parameters.AddWithValue("@LivroId", livroId);
                    cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                    cmd.Parameters.AddWithValue("@DataEmprestimo", dataEmprestimo);
                    cmd.Parameters.AddWithValue("@DataDevolucaoPrevista", dataDevolucaoPrevista);

                    // Executa o comando, registrando o empréstimo
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Caso ocorra algum erro, exibe a mensagem de erro
                Console.WriteLine("Erro ao registrar empréstimo: " + ex.Message);
            }
        }
    }

    internal List<string> ConsultarLivros(string filtro)
    {
        throw new NotImplementedException();
    }
}  // Aqui termina a classe
