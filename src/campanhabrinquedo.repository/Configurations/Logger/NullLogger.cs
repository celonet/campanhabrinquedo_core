using Microsoft.Extensions.Logging;
using System;

namespace campanhabrinquedo.repository.Configurations.Logger
{
    internal class NullLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            //não faz nada
        }
    }
}