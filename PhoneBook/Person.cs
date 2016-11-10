using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, string town, string number)
        {
            this.Name = name;
            this.Town = town;
            this.PhoneNumber = number;
        }
    }
}
