using MySql.Data.MySqlClient;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public void Add(MySqlConnection connection)
    {
        string query = "INSERT INTO Products (Name, Price, Description) VALUES (@name, @price, @desc)";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@desc", Description);
            cmd.ExecuteNonQuery();
        }
    }

    public void Update(MySqlConnection connection)
    {
        string query = "UPDATE Products SET Name = @name, Price = @price, Description = @desc WHERE Id = @id";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@desc", Description);
            cmd.ExecuteNonQuery();
        }
    }

    public void Delete(MySqlConnection connection)
    {
        string query = "DELETE FROM Products WHERE Id = @id";
        using (var cmd = new MySqlCommand(query, connection))
        {
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
        }
    }
}
