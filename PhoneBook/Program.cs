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
            //phoneBook.Serialize("Kireto", "../../phones.xml", "xml");
            //CustomXmlSerializer<HashSet<Person>> xmlSerializer = new CustomXmlSerializer<HashSet<Person>>();
            //xmlSerializer.Serialize(phoneBook.People, new FileWriter("../../phones.xml"));

            //CustomJsonSerializer<HashSet<Person>> jsonSerializer = new CustomJsonSerializer<HashSet<Person>>();
            //jsonSerializer.Serialize(phoneBook, new FileWriter("../../phones.json"));

            //string test = "[{ \"Name\": \"Mimi Shmatkata\", \"Town\": \"Plovdiv\", \"PhoneNumber\": \"0888 12 34 56\"} ]";
            //jsonSerializer.Deserialize(test);

            //HashSet<Person> matches = new HashSet<Person>();
            //matches = phoneBook.FindByNameAndTown("Kireto", "Sofia");
            //foreach (var item in matches)
            //{
            //    Console.WriteLine(item);
            //}

            TextReader commandsReader = new TextReader("../../../commands.txt");
            Splitter commandsSplitter = new Splitter();
            string commands = commandsReader.ReadToEnd2();
            foreach (var item in commands)
            {
                Console.WriteLine(item);
            }
            //foreach (string item in commands)
            //{
            //    string[] splittedCommand = commandsSplitter.SplitText(item, new char[] {'(', ')', ','});
            //    switch (splittedCommand[0])
            //    {
            //        case "find":
            //            if (splittedCommand.Length == 2)
            //            {
            //                phoneBook.FindByName(splittedCommand[1]);
            //            }
            //            else if(splittedCommand.Length == 3)
            //            {
            //                phoneBook.FindByNameAndTown(splittedCommand[1], splittedCommand[2]);
            //            }
            //            break;
                        
            //    }
            //}
        }
    }
}
