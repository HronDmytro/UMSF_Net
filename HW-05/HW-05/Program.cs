using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MySQLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=MyAppDB;User=root;Password=yourpassword";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Додавання користувача
                User user = new User { FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" };
                user.Add(connection);

                // Додавання продукту
                Product product = new Product { Name = "Laptop", Price = 1200.00m, Description = "High performance laptop" };
                product.Add(connection);

                // Додавання завдання
                TaskItem task = new TaskItem { Description = "Fix bug in the system", Status = "In Progress" };
                task.Add(connection);

                // Додавання контакту
                Contact contact = new Contact { Name = "Alice", PhoneNumber = "1234567890", Address = "123 Main St" };
                contact.Add(connection);

                // Додавання замовлення
                Order order = new Order { DishName = "Pizza", IngredientCount = 3, Price = 15.99m, CreatedAt = DateTime.Now };
                order.Add(connection);

                // Перевірка історії замовлень
                List<Order> orders = Order.GetHistory(connection);
                Console.WriteLine("Order History:");
                foreach (var ord in orders)
                {
                    Console.WriteLine($"Dish: {ord.DishName}, Count: {ord.IngredientCount}, Price: {ord.Price}, Date: {ord.CreatedAt}");
                }

                // Зміна статусу завдання
                task.ChangeStatus(connection, "Completed");
                Console.WriteLine($"Task Status Changed: {task.Status}");

                // Оновлення продукту
                product.Description = "Updated product description";
                product.Update(connection);

                // Оновлення контакту
                contact.PhoneNumber = "0987654321";
                contact.Update(connection);

                // Видалення замовлення
                order.Delete(connection);

                // Видалення контакту
                contact.Delete(connection);

                // Видалення продукту
                product.Delete(connection);

                // Видалення завдання
                task.Delete(connection);
            }

            Console.WriteLine("Operations completed.");
        }
    }
}
