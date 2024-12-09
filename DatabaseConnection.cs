using System;
using System.Data.SqlClient;

class DatabaseConnection
{
    private string connectionString = "Driver={SQL Server};Server=localhost;Database=SistemaBiblioteca;Trusted_Connection=True;";

    // Método para obter a conexão com o banco de dados
    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    static void Main(string[] args)
    {
        DatabaseConnection dbConnection = new DatabaseConnection();

        // Obter a conexão com o banco de dados
        using (SqlConnection connection = dbConnection.GetConnection())
        {
            try
            {
                // Abrir a conexão com o banco de dados
                connection.Open();
                Console.WriteLine("Conexão bem-sucedida ao banco de dados!");

                // Aqui você pode adicionar o código para interagir com o banco de dados (consultas, inserções, etc.)

                // Fechar a conexão
                connection.Close();
            }
            catch (Exception ex)
            {
                // Exibir erros, caso a conexão falhe
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}
