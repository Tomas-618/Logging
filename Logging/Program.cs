namespace Logging
{
    internal class Program
    {
        private static void Main()
        {
            ILogger fileLogWritter = new FileLogWritter("log.txt");
            ILogger consoleLogWritter = new ConsoleLogWritter();
            ILogger secureFileLogger = new SecureLogger(fileLogWritter);

            Pathfinder pathfinder1 = new Pathfinder(fileLogWritter);
            Pathfinder pathfinder2 = new Pathfinder(consoleLogWritter);
            Pathfinder pathfinder3 = new Pathfinder(secureFileLogger);
            Pathfinder pathfinder4 = new Pathfinder(new SecureLogger(consoleLogWritter));
            Pathfinder pathfinder5 = new Pathfinder(new CompositeLogger(secureFileLogger));
        }
    }
}
