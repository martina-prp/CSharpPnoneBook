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
        private StreamWriter writer;

        public FileWriter(string path)
        {
            this.writer = new StreamWriter(path);
        }

        public void Write(string text)
        {
            using (this.writer)
            {
                this.writer.Write(text);
            }
        }

        public void WriteLine(string text)
        {
            using (this.writer)
            {
                this.writer.WriteLine(text);
            }
        }
    }
}
