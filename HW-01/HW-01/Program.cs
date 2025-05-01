using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;


        Console.WriteLine("Старт програми...\n");

        // Послідовне виконання
        await RunSequentialAsync();

        Console.WriteLine("\n---");

        // Паралельне виконання
        await RunParallelAsync();

        Console.WriteLine("\nПрограма завершена.");
    }

    //  метод із послідовним виконанням
    static async Task RunSequentialAsync()
    {
        Console.WriteLine("Послідовне виконання:");

        await Task1Async();
        await Task2Async();
        await Task3Async();
    }

    // метод із паралельним виконанням
    static async Task RunParallelAsync()
    {
        Console.WriteLine(" Паралельне виконання:");

        var task1 = Task.Run(() => Task1Async());
        var task2 = Task.Run(() => Task2Async());
        var task3 = Task.Run(() => Task3Async());

        await Task.WhenAll(task1, task2, task3);
    }

    static async Task Task1Async()
    {
        Console.WriteLine("Task 1 стартує...");
        await Task.Delay(1000); //затримкa
        Console.WriteLine("Task 1 завершено.");
    }

    static async Task Task2Async()
    {
        Console.WriteLine("Task 2 стартує...");
        await Task.Delay(1500);
        Console.WriteLine("Task 2 завершено.");
    }

    static async Task Task3Async()
    {
        Console.WriteLine("Task 3 стартує...");
        await Task.Delay(1200);
        Console.WriteLine("Task 3 завершено.");
    }
}
