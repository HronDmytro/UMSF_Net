using MySql.Data.MySqlClient;

public class Order
{
    public int Id { get; set; }
    public string DishName { get; set; }
    public int IngredientCount { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }

    public void Add(MySqlConnection connection)
    {
        string query = "INSERT INTO Orders (DishName, IngredientCount, Price, CreatedAt) VALUES (@DishName, @IngredientCount, @Price, @CreatedAt)";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@DishName", DishName);
        cmd.Parameters.AddWithValue("@IngredientCount", IngredientCount);
        cmd.Parameters.AddWithValue("@Price", Price);
        cmd.Parameters.AddWithValue("@CreatedAt", CreatedAt);
        cmd.ExecuteNonQuery();
    }

    public static List<Order> GetHistory(MySqlConnection connection)
    {
        string query = "SELECT * FROM Orders";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        MySqlDataReader reader = cmd.ExecuteReader();
        List<Order> orders = new List<Order>();
        while (reader.Read())
        {
            orders.Add(new Order
            {
                Id = reader.GetInt32("Id"),
                DishName = reader.GetString("DishName"),
                IngredientCount = reader.GetInt32("IngredientCount"),
                Price = reader.GetDecimal("Price"),
                CreatedAt = reader.GetDateTime("CreatedAt")
            });
        }
        reader.Close();
        return orders;
    }

    public void Delete(MySqlConnection connection)
    {
        string query = "DELETE FROM Orders WHERE Id = @Id";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.ExecuteNonQuery();
    }
}
