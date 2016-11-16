using PhoneBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    // This is a concrete command parser
    class CommandParser<T> : ICommandParser<T>
        where T : ICommandable
    {
        public IEnumerable<Command<T>> ParseCommands(IReader reader)
        {
            List<Command<T>> commands = new List<Command<T>>();

            ISplitter lineSplitter = new Splitter();

            List<string> lines = reader.ReadToEnd();

            foreach (var item in lines)
            {
                string[] command = lineSplitter.SplitText(item, new char[] { '(', ')', ',' });
                string name = command[0];
                object[] commandArgs = command.Select(i => (object) i).Skip(1).ToArray();

                if (name == OperationType.Find.ToString().ToLower())
                {
                    commands.Add(new FindCommand<T>("Find", commandArgs));
                }

                if (name == OperationType.Serialize.ToString().ToLower())
                {
                    string fileName = commandArgs[1].ToString().Trim();
                    
                    string type = commandArgs[2].ToString().Trim();

                    commandArgs = commandArgs.Where((s, ind) => ind == 0).ToArray();

                    ISerializer<HashSet<Person>> serializer = null;

                    if (type == SerializationType.JSON.ToString().ToLower())
                    {
                        serializer = new JSONSerializer<HashSet<Person>>();
                    }
                    else if (type == SerializationType.XML.ToString().ToLower())
                    {

                        serializer = new XMLSerializer<HashSet<Person>>();
                    }

                    Array.Resize(ref commandArgs, 2);
                    commandArgs[1] = serializer;
                    commands.Add(new SerializeCommand<T>("Serialize", commandArgs, fileName));
                }

                if (name == OperationType.Add.ToString().ToLower())
                {
                    Person person = new Person(commandArgs[0].ToString(), commandArgs[1].ToString(), commandArgs[2].ToString());
                    object[] arguments = new object[1] { person };

                    commands.Add(new AddCommand<T>("AddPerson", arguments));
                }
            }

            return commands;
        }

    }
}
