using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class FindCommand<T> : Command<T>
        where T : ICommandable
    {
        public FindCommand(string name, object[] args) : base(name, args)
        {
        }

        public override void PrintCommandResult(T obj)
        {
            ConsoleWriter writer = new ConsoleWriter();

            var result = ExecuteCommand(obj) as HashSet<Person>;

            foreach (var item in result)
            {
                writer.WriteLine(item.ToString());
            }
        }
    }
}
