using PhoneBook.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class SerializeCommand<T> : Command<T>
        where T : ICommandable
    {
        private string fileName;

        public SerializeCommand(string name, object[] args, string fileName) : base(name, args)
        {
            this.fileName = fileName;
        }

        public override void PrintCommandResult(T obj)
        {
            IWriter writer = new FileWriter(fileName);

            var result = ExecuteCommand(obj) as string;

            writer.WriteLine(result);
        }
    }
}
