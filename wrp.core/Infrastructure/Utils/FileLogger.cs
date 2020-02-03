using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Logging;

namespace wrp.core.Infrastructure.Utils
{
    public class FileLogger : ILogger
    {
        private string Path { get; }

        public FileLogger(string folder, string filename)
        {
            Path = System.IO.Path.Combine(folder,"\\", filename).Replace("\\\\","\\");

            EnsureLogFileCreated();
        }

        private void EnsureLogFileCreated()
        {
            if (!Directory.Exists(System.IO.Path.GetDirectoryName(Path)))
            {
                Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path));
            }

            if (File.Exists(Path))
            {
                File.Delete(Path);
                File.Create(Path);
                return;
            }

            File.Create(Path);
        }

        public void Write(string message)
        {
            File.AppendAllLines(Path, new[] { $"{DateTime.Now:O}: {message}" });
        }
    }
}
