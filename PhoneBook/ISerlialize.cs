using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    interface ISerlialize
    {
        void Serialize(PhoneBook data, string toFile, IWriter writer);

        void Deserialize();
    }
}
