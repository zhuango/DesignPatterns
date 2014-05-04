namespace DesignPatterns
{
    using System;
    using System.Text;
    using System.Globalization;
    using System.IO;
    using System.Threading;

    public class FileLogger : ILogger
    {
        private static FileLogger logger = null;
        private static object forLock = new object();
        private string loggerPath = string.Empty;
        private static string loggerName = string.Empty;
        private static int loggerCount = 1;
        private const int loggerSize = 1024 * 1024 * 2;

        private FileLogger()
        {
        }

        public void SetLoggerPath(string loggerPath)
        {
            this.loggerPath = loggerPath;
            if (string.IsNullOrEmpty(loggerPath))
            {
                this.loggerPath = Environment.CurrentDirectory + "\\";
            }

        }

        public static FileLogger GetInstance()
        {
            if (logger == null)
            {
                lock (forLock)
                {
                    if (logger == null)
                    {
                        logger = new FileLogger();
                    }
                }
            }
            return logger;
        }


        public void Logger(LoggerType loggerType, string format, params object[] parameters)
        {
            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat("{0} [Thread ID: {1}]\t{2}\t\t", DateTime.Now.ToString("dd-MM-yyyy_HH:mm:ss", DateTimeFormatInfo.InvariantInfo), Thread.CurrentThread.ManagedThreadId.ToString(), loggerType);
                stringBuilder.AppendFormat(format, parameters);
                stringBuilder.AppendLine();

                lock (forLock)
                {
                    loggerName = String.Format("{0}{1}{2}{3}", loggerPath, DateTime.Now.ToString("dd-MM-yyyy", DateTimeFormatInfo.InvariantInfo), "_log_", loggerCount.ToString(), ".log");
                    while (BigEnough())
                    {
                        loggerName = String.Format("{0}{1}{2}{3}", loggerPath, DateTime.Now.ToString("dd-MM-yyyy", DateTimeFormatInfo.InvariantInfo), "_log_", loggerCount.ToString(), ".log");
                    }
                    using (StreamWriter writer = new StreamWriter(loggerName, true, Encoding.UTF8))
                    {
                        writer.Write(stringBuilder.ToString());
                        writer.Flush();
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO
                Console.WriteLine(ex.ToString());
            }
        }

        private bool BigEnough()
        {
            if (!File.Exists(loggerName))
            {
                return false;
            }

            FileInfo fileinfo = new FileInfo(loggerName);
            if (fileinfo.Length > loggerSize)
            {
                loggerCount++;
                return true;
            }
            return false;
        }

        public void Info(string format, params object[] parameters)
        {
            Logger(LoggerType.Info, format, parameters);
        }

        public void Debug(string format, params object[] parameters)
        {
            Logger(LoggerType.Debug, format, parameters);
        }

        public void Error(string format, params object[] parameters)
        {
            Logger(LoggerType.Error, format, parameters);
        }

        public void Warning(string format, params object[] parameters)
        {
            Logger(LoggerType.Warning, format, parameters);
        }

    }
}
