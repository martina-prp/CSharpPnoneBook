using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Contracts
{
    public interface ICommandParser<T>
        where T:ICommandable
    {
        IEnumerable<Command<T>> ParseCommands(IReader reader);
    }
}
