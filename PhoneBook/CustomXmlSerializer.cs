using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace PhoneBook
{
    class CustomXmlSerializer<T> : ISerlializer<T>
    {
        public void Serialize(T data, IWriter writer)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, data);
            writer.WriteLine(stringWriter.ToString());
        }

        public void Deserialize(string data) // ???
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlReader reader = XmlReader.Create("../../phones.xml");
            using(reader)
            {
                PhoneBook pB = serializer.Deserialize(reader) as PhoneBook;
            }
        }
    }
}
