using PhoneBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class AddCommand<T> : Command<T>
        where T : ICommandable
    {
        public AddCommand(string name, object[] args) : base(name, args)
        {
        }

        public override void PrintCommandResult(T obj)
        {
            ConsoleWriter writer = new ConsoleWriter();

            var result = ExecuteCommand(obj);

            writer.WriteLine(string.Format("The Person is added to the PhoneBook -> {0}", result));
        }
    }
}
