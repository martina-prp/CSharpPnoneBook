using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public interface ISerializer<T>
    {
        string Serialize(T data);

        T Deserialize(string text);
    }
}
