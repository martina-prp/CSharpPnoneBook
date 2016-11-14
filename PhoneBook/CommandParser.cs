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
                string[] command = lineSplitter.SplitText(item, new char[] { '(', ')', ',', ' ' });
                string name = command[0];
                object[] commandArgs = command.Select(i => (object) i).Skip(1).ToArray();
                if (name == OperationType.Find.ToString().ToLower())
                {
                    commands.Add(new FindCommand<T>("Find", commandArgs));
                }
            }

            return commands;
        }

    }
}
