using System;
using System.IO;
using System.Text;

namespace Logger
{
    public sealed class Log : ILog
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
        public static Log GetInstance => instance.Value;
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1:MMM_dd_yyyy}.log", "Exception", DateTime.Now);
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
