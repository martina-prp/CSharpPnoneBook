using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Contracts
{
    public interface IReader
    {
        string ReadLine();

        List<string> ReadToEnd();
    }
}
