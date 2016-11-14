using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Splitter : ISplitter
    {
        public string[] SplitText(string text, char[] splitter)
        {
            return text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
