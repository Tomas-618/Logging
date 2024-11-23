using System;

namespace Logging
{
    public class SecureLogger : ILogger
    {
        private readonly ILogger _logger;

        public SecureLogger(ILogger logger) =>
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public void WriteError(string message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                _logger.WriteError(message);
        }
    }
}
