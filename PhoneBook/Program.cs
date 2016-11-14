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
            FileReader reader = new FileReader("../../../phones.txt");
            IPhoneBookParser phoneBookParser = new PhoneBookParser();
            PhoneBook phoneBook = phoneBookParser.ParseData(reader);

            FileReader commandsReader = new FileReader("../../../commands.txt");
            CommandParser<PhoneBook> commandsParser = new CommandParser<PhoneBook>();
            IEnumerable<Command<PhoneBook>> commandList = commandsParser.ParseCommands(commandsReader);
            
            foreach (var c in commandList)
            {
                c.PrintCommandResult(phoneBook);

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item);
                //}
   
            }

            //Splitter commandsSplitter = new Splitter();
            //string[] commands = commandsSplitter.SplitText(commandsReader.ReadToEnd(), new char[] { '\n', '\r' });

            //foreach (string item in commands)
            //{
            //    string[] splittedCommand = commandsSplitter.SplitText(item, new char[] { '(', ')', ',', ' ' });
            //    switch (splittedCommand[0])
            //    {
            //        case "find":
            //            Console.WriteLine("----------------------------------");
            //            HashSet<Person> found = new HashSet<Person>();

            //            if (splittedCommand.Length == 2)
            //            {
            //                found = phoneBook.Find(splittedCommand[1]);
            //            }
            //            else if (splittedCommand.Length == 3)
            //            {
            //                found = phoneBook.Find(splittedCommand[1], splittedCommand[2]);
            //            }

            //            foreach (var person in found)
            //            {
            //                Console.WriteLine(person);
            //            }
            //            break;

            //        case "serialize":
            //            if (splittedCommand[3] == "xml")
            //            {
            //                ISerializer<HashSet<Person>> XMLSerializer = new XMLSerializer<HashSet<Person>>();

            //                IWriter XMLwriter = new FileWriter(splittedCommand[2]);

            //                XMLwriter.WriteLine(phoneBook.Serialize(splittedCommand[1], XMLSerializer));
            //            }

            //            if (splittedCommand[3] == "json")
            //            {
            //                ISerializer<HashSet<Person>> serializer = new JSONSerializer<HashSet<Person>>();

            //                IWriter writer = new FileWriter(splittedCommand[2]);

            //                writer.WriteLine(phoneBook.Serialize(splittedCommand[1], serializer));
            //            }
            //            break;

            //        case "add":
            //            phoneBook.AddPerson(new Person(splittedCommand[1], splittedCommand[2], splittedCommand[3]));
            //            break;

            //        default:
            //            Console.WriteLine("Invalid operation!");
            //            break;
            //    }
            //}
        }
    }
}
