using System;
using System.IO;

namespace Logging
{
    public class FileLogWritter : ILogger
    {
        private readonly string _path;

        public FileLogWritter(string path) =>
            _path = path ?? throw new ArgumentNullException(nameof(path));

        public void WriteError(string message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            File.WriteAllText(_path, message);
        }
    }
}
