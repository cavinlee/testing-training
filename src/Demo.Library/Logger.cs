using System;

namespace Demo.Library
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            // sql
        }
    }

}