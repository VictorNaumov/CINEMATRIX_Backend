using log4net;

using System;

/// <summary>
/// Process All Log Messages to Log File
/// </summary>
namespace CINEMATRIX.WPF.Helpers

{
    public class LogHelper
    {
        private static readonly ILog Logger;

        private static ILog GetLogger(string logName)
        {
            var log = LogManager.GetLogger(logName);
            return log;
        }

        static LogHelper()
        {
            Logger = GetLogger("Define");
        }

        /// <summary>
        /// Debug Message
        /// </summary>
        /// <param name="message"></param>
        public static void Debug(string message)
        {
            Logger.Debug(message);
        }

        /// <summary>
        /// Info Message
        /// </summary>
        /// <param name="message"></param>
        public static void Info(string message)
        {
            Logger.Info(message);
        }

        /// <summary>
        /// Warn Message
        /// </summary>
        /// <param name="message"></param>
        public static void Warn(string message)
        {
            Logger.Warn(message);
        }

        /// <summary>
        /// Error Message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public static void Error(string message, Exception e = null)
        {
            Logger.Error(message, e);
        }

        /// <summary>
        /// Fatal Message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public static void Fatal(string message, Exception e = null)
        {
            Logger.Fatal(message, e);
        }

        /// <summary>
        /// Exception Message
        /// </summary>
        /// <param name="e"></param>
        public static void LogException(Exception e)
        {
            Logger.Error("Exception has been thrown", e);
        }
    }
}
