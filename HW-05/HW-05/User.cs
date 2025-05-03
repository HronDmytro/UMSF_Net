using MySql.Data.MySqlClient;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public void Add(MySqlConnection connection)
    {
        string query = "INSERT INTO Users (FirstName, LastName, Email) VALUES (@first, @last, @mail)";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@first", FirstName);
            cmd.Parameters.AddWithValue("@last", LastName);
            cmd.Parameters.AddWithValue("@mail", Email);
            cmd.ExecuteNonQuery();
        }
    }
}
