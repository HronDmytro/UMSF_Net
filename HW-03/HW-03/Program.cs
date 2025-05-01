using System;
using System.IO;
using HW_03;
class Program
{

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        var calculator = new Calculator();
        try
        {
            Console.WriteLine(calculator.Divide(10, 5));
        }
        catch (DivideByZeroException) { }

        var fileReader = new FileReader();
        try
        {
            Console.WriteLine(fileReader.ReadFile("example.txt"));
        }
        catch (FileNotFoundException) { }

        var arrayProcessor = new ArrayProcessor();
        try
        {
            Console.WriteLine(arrayProcessor.Process(new double[] { 2, 4, 5, 8, 11}));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при обробці масиву: {ex.Message}");
        }
    }
}

