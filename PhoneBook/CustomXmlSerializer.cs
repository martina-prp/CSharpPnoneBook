using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections;

namespace PhoneBook
{
    class CustomXmlSerializer<T> : ISerlializer<T> where T : IEnumerable
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
            T obj = default(T);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(data))
            {
                obj = (T)serializer.Deserialize(reader);
            }
            foreach (var item in obj)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
