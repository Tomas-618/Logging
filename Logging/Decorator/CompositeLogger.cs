using System;

namespace Logging
{
    public class CompositeLogger : ILogger
    {
        private readonly ILogger[] _loggers;

        public CompositeLogger(params ILogger[] loggers) =>
            _loggers = loggers ?? throw new ArgumentNullException(nameof(loggers));

        public void WriteError(string message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            foreach (ILogger logger in _loggers)
                logger.WriteError(message);
        }
    }
}
