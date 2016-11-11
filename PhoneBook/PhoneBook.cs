using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBook : IEnumerable
    {
        public HashSet<Person> People { get; set; }
        
        public PhoneBook()
        {
            IEqualityComparer<Person> comparer = new PersonComparer(); // !!!!!
            People = new HashSet<Person>(comparer); // !!!!
        }

        public bool AddPerson(Person person)
        {
            if (!(this.People.Contains(person)))
            {
                People.Add(person);
                return true;
            }

            return false;
        }

        public HashSet<Person> Find(string name)
        {
            HashSet<Person> personMatches = new HashSet<Person>();
            List<Person> personList = People.Where(person => person.Name == name).ToList();
            foreach (var item in personList)
            {
                personMatches.Add(item);
            }

            return personMatches;
        }

        public HashSet<Person> Find(string name, string town)
        {
            HashSet<Person> personMatches = new HashSet<Person>();
            List<Person> personList = People.Where(person => (person.Name == name && person.Town == town)).ToList<Person>();
            foreach (var item in personList)
            {
                personMatches.Add(item);
            }

            return personMatches;
        }

        public void Serialize(string name, ISerlializer<HashSet<Person>> serializer)
        {
            HashSet<Person> setToBeserialise = Find(name);
            //serializer.Serialize(setToBeserialise);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var item in People)
            {
                yield return item;
            }
        }
    }

}
