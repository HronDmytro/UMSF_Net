using MySql.Data.MySqlClient;

public class TaskItem
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }

    public void Add(MySqlConnection connection)
    {
        string query = "INSERT INTO Tasks (Description, Status) VALUES (@Description, @Status)";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Description", Description);
        cmd.Parameters.AddWithValue("@Status", Status);
        cmd.ExecuteNonQuery();
    }

    public void ChangeStatus(MySqlConnection connection, string newStatus)
    {
        string query = "UPDATE Tasks SET Status = @Status WHERE Id = @Id";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Status", newStatus);
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.ExecuteNonQuery();
        Status = newStatus;
    }

    public void Delete(MySqlConnection connection)
    {
        string query = "DELETE FROM Tasks WHERE Id = @Id";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@Id", Id);
        cmd.ExecuteNonQuery();
    }
}
