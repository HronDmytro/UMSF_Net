namespace HW_03
{
    public class Calculator
    {
        public double Divide(double numerator, double denominator)
        {
            try
            {
                return numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Помилка: ділення на нуль.");
                throw; 
            }
        }
    }
}
