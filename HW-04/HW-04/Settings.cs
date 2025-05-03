public class Settings
{
    private static Settings _instance;
    private static readonly object _lock = new();

    public string Language { get; set; }
    public int WindowSize { get; set; }

    private Settings()
    {
        Language = "en";
        WindowSize = 800;
    }

    public static Settings Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Settings();
            }
        }
    }
}
