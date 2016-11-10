using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PhoneBook
    {
        private HashSet<Person> People { get; set; }
        
        public PhoneBook()
        {
            IEqualityComparer<Person> comparer = new PersonComparer(); // !!!!!
            People = new HashSet<Person>(comparer); // !!!!
        }

        public bool AddPerson(Person person)
        {
            Console.WriteLine(this.People.Contains(person));
            if (!(this.People.Contains(person)))
            {
                People.Add(person);
                return true;
            }

            return false;
        }
    }

}
