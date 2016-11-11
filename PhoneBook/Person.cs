using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Person
    {
        public string Name { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
            this.Name = "No name";
            this.Town = "No town";
            this.PhoneNumber = "";
        }

        public Person(string name, string town, string number)
        {
            this.Name = name;
            this.Town = town;
            this.PhoneNumber = number;
        }

        public override string ToString()
        {
            return String.Format("{0}  |  {1}  |  {2}", this.Name, this.Town, this.PhoneNumber);
        }
    }
}
