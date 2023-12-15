using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CamelCards_Day7
{
    public static class FileManager
    {
        public static string ReadData(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);
            }

            return string.Empty;
        }
    }
}
