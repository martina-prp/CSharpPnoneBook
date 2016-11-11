using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneBookTests
    {
        PhoneBook phoneBook;

        [TestInitialize]
        public void BeforeAllTests()
        {
            Factory factory = new Factory();
            this.phoneBook = factory.Create();
        }

        [TestMethod]
        public void AddPersonShouldAddPersonToPhoneBook()
        {
            bool resultSuccess = phoneBook.AddPerson(new Person("Pesho", "Varna", "087 234 567"));

            Assert.AreEqual(true, resultSuccess);

            bool resultFail = phoneBook.AddPerson(new Person("Pesho", "Varna", "052 23 45 68"));

            Assert.AreEqual(false, resultFail);
        }
        
        [TestMethod]
        public void AddPersonShouldAddOnlyOnePersonToPhoneBook()
        {
            int initialCount = phoneBook.People.Count;

            phoneBook.AddPerson(new Person("Pesho", "Varna", "087 234 987"));

            Assert.AreEqual(phoneBook.People.Count, initialCount + 1);
        }

        [TestMethod]
        public void FindByNameShouldFindAllPeopleByName()
        {
            HashSet<Person> found = phoneBook.FindByName("Kireto");
            HashSet<Person> expectedResult = new HashSet<Person>();
            expectedResult.Add(new Person("Kireto", "Varna", "052 23 45 67"));
            expectedResult.Add(new Person("Kireto", "Sofia", "052 23 45 68"));
            List<Person> personList = expectedResult.ToList();
 
            Assert.AreEqual(2, expectedResult.Count);

            Assert.AreEqual("Kireto", personList[0].Name);
        }

        [TestMethod]
        public void FindByNameAndTownShouldFindAllPeopleByNameAndTown()
        {
            HashSet<Person> found = phoneBook.FindByNameAndTown("Kireto", "Varna");
            HashSet<Person> expectedResult = new HashSet<Person>();
            expectedResult.Add(new Person("Kireto", "Varna", "052 23 45 67"));
            List<Person> personList = expectedResult.ToList();

            Assert.AreEqual(1, expectedResult.Count);

            Assert.AreEqual("Kireto", personList[0].Name);
        }
    }
}
