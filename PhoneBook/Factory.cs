using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Factory
    {
        public PhoneBook Create()
        {
            PhoneBook phoneBook = new PhoneBook();

            TextReader txtReader = new TextReader("../../phones.txt");

            List<string> text = txtReader.ReadToEnd();

            Splitter splitter = new Splitter();

            foreach (var item in text)
            {
                string[] splitted = splitter.SplitText(item, new char[] { '|' });
                Person person = new Person(splitted[0], splitted[1], splitted[2]);
                phoneBook.AddPerson(person);
            }

            return phoneBook;
        }
    }
}
