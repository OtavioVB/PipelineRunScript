using MySql.Data.MySqlClient;

namespace Pipeline;

public class Program
{
    static void Main()
    {
        var dataConnection = new MySqlConnection("server=127.0.0.1;database=pipeline;uid=otavio;pwd=1234;port=3306");
        dataConnection.Open();
        var command = dataConnection.CreateCommand();
        command.CommandText = "INSERT INTO TB_EXAMPLE (N_ID, T_NOME) VALUES (@ID, @Nome)";
        command.Parameters.AddWithValue("@ID", 1);
        command.Parameters.AddWithValue("@Nome", "Otavio");
        command.ExecuteNonQuery();
    }
}