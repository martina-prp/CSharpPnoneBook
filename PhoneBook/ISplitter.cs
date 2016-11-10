using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    interface ISplitter
    {
        string[] SplitText(string text, char[] splitter);
    }
}
