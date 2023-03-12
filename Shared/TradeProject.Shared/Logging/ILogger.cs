using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace TradeProject.Shared.Logging
{
    public interface ILogger
    {
        void LogInformation(string application, string logName, string message, object data = null);
        void LogWarning(string application, string logName, string message, object data = null);
        void LogError(string application, string logName, Exception exception, object data = null);
    }
}
