using System;

namespace FAAI2020WebAPi
{
    public interface ILogger<T> where T : class
    {
        void Log(string message);
    }

    public class Logger<T> : ILogger<T> where T : class
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log from {typeof(T)}, message: {message}");
        }
    }
}
