namespace HW_03
{
    public class FileReader
    {
        public string ReadFile(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Помилка: файл не знайдено.");
                throw;
            }
        }
    }
}
