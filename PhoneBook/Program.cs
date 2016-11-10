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
            Factory phoneBookFactory = new Factory();
            PhoneBook phoneBook = phoneBookFactory.Create();
        }
    }
}
