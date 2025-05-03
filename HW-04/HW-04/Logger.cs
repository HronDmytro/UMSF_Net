public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new();
    private List<string> _logs = new();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                return _instance ??= new Logger();
            }
        }
    }

    public void AddLog(string message)
    {
        _logs.Add($"[{DateTime.Now}] {message}");
    }

    public IEnumerable<string> GetLogs() => _logs;
}
