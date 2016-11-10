using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class FileWriter : IWriter
    {
        public string Path { get; set; }

        public FileWriter(string path)
        {
            this.Path = path;
        }

        public void Write(string text)
        {
            StreamWriter writer = new StreamWriter(this.Path);
            using (writer)
            {
                writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            StreamWriter writer = new StreamWriter(this.Path);
            using (writer)
            {
                writer.WriteLine(text);
            }
        }
    }
}
