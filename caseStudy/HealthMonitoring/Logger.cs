using System;

namespace HealthMonitoring
{

    // Logger implementation two

    public enum Severity
    {
        Verbose,
        Trace,
        Information,
        Warning,
        Error,
        Critical
    }



    public static class Logger
    {
        public static Action<string> WriteMessage;

        public static Severity LogLevel { get; set; } = Severity.Warning;

        public static void LogMessage(Severity s, string component, string msg)
        {
            if (s < LogLevel)
                return;

            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
            WriteMessage(outputMsg);
        }
    }

}

namespace ImplementationOne
{

    public static class Logger
    {
        public static Action<string> WriteMessage;

        public static void LogMessage(string msg)
        {
            WriteMessage(msg);
        }
    }

}

namespace ImplementationTwo
{
    using HealthMonitoring;

    public static class Logger
    {
        public static Action<string> WriteMessage;

        public static void LogMessage(Severity s, string component, string msg)
        {
            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
            WriteMessage(outputMsg);
        }
    }
}
