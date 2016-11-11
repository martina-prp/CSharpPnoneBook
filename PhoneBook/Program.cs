using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory phoneBookFactory = new Factory();
            PhoneBook phoneBook = phoneBookFactory.Create();
            //CustomXmlSerializer<PhoneBook> xmlSerializer = new CustomXmlSerializer<PhoneBook>();
            //xmlSerializer.Serialize(phoneBook, new FileWriter("../../phones.xml"));

            //CustomJsonSerializer<PhoneBook> jsonSerializer = new CustomJsonSerializer<PhoneBook>();
            //jsonSerializer.Serialize(phoneBook, new FileWriter("../../phones.json"));

            //string test = "{\"People\": { \"Name\": \"Mimi Shmatkata\", \"Town\": \"Plovdiv\", \"PhoneNumber\": \"0888 12 34 56\"} }";
            //jsonSerializer.Deserialize(test);

            HashSet<Person> matches = new HashSet<Person>();
            matches = phoneBook.FindByNameAndTown("Kireto", "Sofia");
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
