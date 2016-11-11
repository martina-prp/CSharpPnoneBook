using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Factory
    {
        public PhoneBook Create()
        {
            PhoneBook phoneBook = new PhoneBook();

            TextReader txtReader = new TextReader("../../../phones.txt");

            List<string> text = txtReader.ReadToEnd();

            Splitter splitter = new Splitter();

            foreach (var item in text)
            {
                string[] splitted = splitter.SplitText(item, new char[] { '|' });
                Person person = new Person(splitted[0].Trim(), splitted[1].Trim(), splitted[2].Trim());
                phoneBook.AddPerson(person);
            }

            return phoneBook;
        }
    }
}
