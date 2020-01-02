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

    public class DummyLogger : ILogger
    {
        public void Log(string message)
        {
        }
    }

}