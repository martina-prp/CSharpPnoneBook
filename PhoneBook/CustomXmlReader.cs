using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhoneBook
{
    class CustomXmlReader : IReader
    {
        public string Path { get; set; }

        public CustomXmlReader(string path)
        {
            this.Path = path;
        } 

        public string ReadLine()
        {
            //XmlReader reader = XmlReader.Create(this.Path);

            //string node = reader.Read();

            return "";
        }

        public string ReadToEnd()
        {
            throw new NotImplementedException();
        }
    }
}
