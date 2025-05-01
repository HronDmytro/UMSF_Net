namespace HW_03
{
    public class ArrayProcessor
    {
        public double Process(double[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "Масив не може бути null.");
            }

            if (numbers.Length == 0)
            {
                throw new ArgumentException("Масив не може бути порожнім.", nameof(numbers));
            }

            double sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }
    }
}
