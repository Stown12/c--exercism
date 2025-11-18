static class LogLine
{
    public static string Message(string logLine)
    {
        string message = logLine.Split([':'])[1];

        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        string log = logLine.Split([':'])[0];
        string logWithoutSymbols = log.Trim(['[', ']']);

        return logWithoutSymbols.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = LogLine.Message(logLine);
        string logText = LogLine.LogLevel(logLine);

        return ($"{message} ({logText})");
    }
}
