using MySql.Data.MySqlClient;

public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }

    public void Add(MySqlConnection connection)
    {
        string query = "INSERT INTO Contacts (Name, PhoneNumber, Address) VALUES (@name, @phone, @address)";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@phone", PhoneNumber);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.ExecuteNonQuery();
        }
    }

    public void Update(MySqlConnection connection)
    {
        string query = "UPDATE Contacts SET Name = @name, PhoneNumber = @phone, Address = @address WHERE Id = @id";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@phone", PhoneNumber);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.ExecuteNonQuery();
        }
    }

    public void Delete(MySqlConnection connection)
    {
        string query = "DELETE FROM Contacts WHERE Id = @id";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
        }
    }
}
