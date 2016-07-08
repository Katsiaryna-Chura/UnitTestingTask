using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTestingTask
{
    public class Logger
    {
        public string FilePath { get; private set; }

        public Logger(string framework)
        {
            FilePath = $@"{FileData.DirPath}\{framework}Log.txt";
        }

        public void Log(string text)
        {
            File.AppendAllText(FilePath, $"{text}\n");
        }
    }
}
