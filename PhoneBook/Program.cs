using PhoneBook.Contracts;
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
            }
        }
    }
}
