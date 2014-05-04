namespace DesignPatterns
{
    public enum LoggerType
    {
        Info,
        Debug,
        Error,
        Warning,
    }

    public interface ILogger
    {
        void SetLoggerPath(string loggerPath);
        void Logger(LoggerType loggerType, string format, params object[] parameters);
        void Info(string format, params object[] parameters);
        void Debug(string format, params object[] parameters);
        void Error(string format, params object[] parameters);
        void Warning(string format, params object[] parameters);
    }
}
