using System;
using System.IO;

namespace extensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        // to further reduce boilerplate here we could use enumerations
        public void LogError(string message)
        {
            Log(message, "-|-||-|||-ERROR-|||-||-|-: ");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO:");
        }

        public void LogSuccess(string message)
        {
            Log(message, "success! ||||| ");
        }

        private void Log(string message, string messageType) // no boilerplate let's GO
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + message);
            }

            Console.WriteLine("logged successfully!");
        }
    }
}