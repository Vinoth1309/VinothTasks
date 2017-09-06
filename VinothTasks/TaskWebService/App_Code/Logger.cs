using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;

public static class Logger
{
    public static ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    /// <summary>
    /// Log the debug message using Log4net
    /// </summary>
    /// <param name="message">Message to log in log file</param>
    public static void LogDebugMessage(object message)
    {

        if (log.IsDebugEnabled)
        {
            log.Debug(message);
        }
    }

    /// <summary>
    /// Log the exception message using Log4net
    /// </summary>
    /// <param name="message">Message to log in log file </param>
    public static void LogErrorMessage(object message)
    {
        if (log.IsErrorEnabled)
        {
            log.Error(message);
        }
    }

    /// <summary>
    /// Log the information message using Log4net
    /// </summary>
    /// <param name="message">Message to log in log file</param>
    public static void LogInfoMessage(object message)
    {
        if (log.IsInfoEnabled)
        {
            log.Info(message);
        }
    }

    public static void LogParamInfoMessage(object message)
    {
        if (log.IsInfoEnabled)
        {
            log.Info(message);
        }
    }


    /// <summary>
    /// Method to Initialize the logger component
    /// Should be called only from application start up event.
    /// </summary>
    /// <param name="logger">Logger instance name</param>
    public static void ConfigureLog(string logger)
    {
        log = LogManager.GetLogger(logger);
        if (!log.Logger.Repository.Configured)
        {
            XmlConfigurator.Configure();
        }

        log.Info("Logger is configured.");
    }
}

