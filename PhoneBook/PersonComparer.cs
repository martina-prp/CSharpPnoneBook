using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x.PhoneNumber == y.PhoneNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Person obj)
        {
            return obj.PhoneNumber.GetHashCode(); // !!!!!!
        }
    }
}
