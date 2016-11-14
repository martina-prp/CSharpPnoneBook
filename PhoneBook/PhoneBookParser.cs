using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneBookParser : IPhoneBookParser
    {
        public PhoneBook ParseData(IReader reader)
        {
            PhoneBook newPhoneBook = new PhoneBook();

            string data = reader.ReadToEnd();

            ISplitter splitter = new Splitter();

            string[] splittedData = splitter.SplitText(data, new char[] {'|', '\n'});

            for (int i = 0; i < splittedData.Length; i += 3)
            {
                newPhoneBook.AddPerson(new Person(splittedData[i], splittedData[i + 1], splittedData[i + 2]));
            }

            return newPhoneBook;
        }
    }
}
