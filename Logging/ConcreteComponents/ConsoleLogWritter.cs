using System;

namespace Logging
{
    public class ConsoleLogWritter : ILogger
    {
        public void WriteError(string message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            Console.WriteLine(message);
        }
    }
}
