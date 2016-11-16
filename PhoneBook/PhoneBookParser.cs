using PhoneBook.Contracts;
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

            List<string> data = reader.ReadToEnd();

            ISplitter splitter = new Splitter();

            foreach (var item in  data)
            {
                string[] splittedData = splitter.SplitText(item, new char[] { '|' });
                newPhoneBook.AddPerson(new Person(splittedData[0].Trim(), splittedData[1].Trim(), splittedData[2].Trim()));
            }

            return newPhoneBook;
        }
    }
}
