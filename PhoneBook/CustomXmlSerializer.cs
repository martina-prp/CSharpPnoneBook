using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace PhoneBook
{
    class CustomXmlSerializer : ISerlialize
    {
        public void Serialize(PhoneBook phoneBook, string path, IWriter writer)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(PhoneBook));
            TextWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, phoneBook);
            writer.WriteLine(stringWriter.ToString());
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }

        public void Serialize(PhoneBook data, string toFile)
        {
            throw new NotImplementedException();
        }
    }
}
