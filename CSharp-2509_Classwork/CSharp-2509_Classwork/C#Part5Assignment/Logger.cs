using System;
using log4net;
using log4net.Config;

public class Logger
{
    private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

    static Logger()
    {
        XmlConfigurator.Configure();
    }

    public static void LogError(string message, Exception ex)
    {
        log.Error(message, ex);
    }
}