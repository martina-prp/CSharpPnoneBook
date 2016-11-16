using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections;
using PhoneBook.Contracts;

namespace PhoneBook
{
    class XMLSerializer<T> : ISerializer<T> where T : IEnumerable
    {
        public string Serialize(T data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, data);

            return stringWriter.ToString();
        }

        public T Deserialize(string data)
        {
            T obj = default(T);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(data))
            {
                obj = (T)serializer.Deserialize(reader);
            }

            return obj;
        }
    }
}
