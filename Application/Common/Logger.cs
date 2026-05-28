using System;

namespace SmartCampus.Application.Common
{
    public class Logger
    {
        private static Logger? _instance;
        private static readonly object _lockObject = new object();

        private Logger() { }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                        Console.WriteLine("[SİSTEM] Logger nesnesi Singleton Pattern ile tekil olarak üretildi.");
                    }
                }
            }
            return _instance;
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now:HH:mm:ss}]: {message}");
        }
    }
}