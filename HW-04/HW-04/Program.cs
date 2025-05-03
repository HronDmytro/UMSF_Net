using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;


        //  Singleton: Logger
        Logger.Instance.AddLog("Програма запущена");
        Logger.Instance.AddLog("Завантаження налаштувань...");

        //  Singleton: Settings 
        var settings = Settings.Instance;
        settings.Language = "uk";
        settings.WindowSize = 1024;
        Logger.Instance.AddLog($"Налаштування: Мова = {settings.Language}, Розмір вікна = {settings.WindowSize}");

        //  Builder: Character 
        var hero = new CharacterBuilder().SetStrength(10).SetAgility(8).SetIntelligence(6).Build();
        Console.WriteLine($"Створено персонаж: {hero}");
        Logger.Instance.AddLog("Персонаж створено");

        //  Builder: SQL Query 
        var sql = new SqlQueryBuilder().Select("*").Where("age > 18").OrderBy("name").Build();
        Console.WriteLine($"SQL-запрос: {sql}");
        Logger.Instance.AddLog("Сформовано SQL-запит");

        //  Bridge: Повідомлення 
        Message textViaEmail = new TextMessage(new EmailSender());
        textViaEmail.Send("Привіт, це звичайне повідомлення");

        Message htmlViaSms = new HtmlMessage(new SmsSender());
        htmlViaSms.Send("Це <b>HTML</b> повідомлення");

        Logger.Instance.AddLog("Повідомлення надіслані");

        //  Bridge: Присторої 
        IDevice tv = new TV();
        Remote tvRemote = new BasicRemote(tv);
        tvRemote.TogglePower();
        tvRemote.TogglePower();

        IDevice radio = new Radio();
        Remote radioRemote = new BasicRemote(radio);
        radioRemote.TogglePower();

        Logger.Instance.AddLog("Пристрої включені та вимкнені");

        //  Вивід журнала логів 
        Console.WriteLine("\n--- Журнал логів ---");
        foreach (var log in Logger.Instance.GetLogs())
            Console.WriteLine(log);
    }
}
