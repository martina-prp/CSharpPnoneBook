using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public abstract class Command<T>
        where T : ICommandable
    {
        public string CommandName { get; set; }
        public object[] CommandArguments { get; set; }

        public Command()
        {
            CommandArguments = null;
        }

        public Command(string name, object[] args)
        {
            CommandName = name;
            CommandArguments = new object[args.Length];
            Array.Copy(args, CommandArguments, args.Length);
        }

        protected object ExecuteCommand(T obj)
        {
            var objType = typeof(T);
            Type[] arguments = new Type[CommandArguments.Length];

            for (int i = 0; i < CommandArguments.Length; i++)
            {
                Console.WriteLine(CommandArguments[i]);
                arguments[i] = CommandArguments[i].GetType();
            }
            var method = objType.GetMethod(CommandName, arguments);
            object result = method.Invoke(obj, CommandArguments);

            return result;
        }

        public abstract void PrintCommandResult(T obj);
    }
}
