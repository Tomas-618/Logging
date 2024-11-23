using System;

namespace Logging
{
    public class Pathfinder
    {
        private readonly ILogger _logger;

        public Pathfinder(ILogger logger) =>
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public void Find() =>
            _logger.WriteError("что-то пишет в лог.");
    }
}
