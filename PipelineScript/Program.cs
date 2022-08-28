using MySql.Data.MySqlClient;

namespace Pipeline;

public class Program
{
    static void Main()
    {
        var dataConnection = new MySqlConnection(Environment.GetEnvironmentVariable("DB_CONNECTION_STRING"));
        dataConnection.Open();
        var command = dataConnection.CreateCommand();
        command.CommandText = "INSERT INTO TB_EXAMPLE (N_ID, T_NOME) VALUES (@ID, @Nome)";
        command.Parameters.AddWithValue("@ID", 1);
        command.Parameters.AddWithValue("@Nome", "Otavio");
        command.ExecuteNonQuery();
    }
}