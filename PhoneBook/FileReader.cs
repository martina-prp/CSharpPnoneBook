using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class FileReader : IReader
    {
        public string Path { get; set; }

        public FileReader(string path)
        {
            this.Path = path;
        }

        public string ReadLine()
        {
            try
            {
                StreamReader reader = new StreamReader(this.Path);
                using (reader)
                {
                    return reader.ReadLine();
                } 
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public List<string> ReadToEnd()
        {
            List<string> text = new List<string>();
            string line;
            StreamReader reader = new StreamReader(this.Path);
            using (reader)
            {
                while ((line = reader.ReadLine()) != null) //return reader.ReadToEnd();
                {
                    text.Add(line);
                }
            }

            return text;
        }

        //public string ReadToEnd()
        //{
        //    StreamReader reader = new StreamReader(this.Path);

        //    return reader.ReadToEnd(); ;
        //}
    }
}
