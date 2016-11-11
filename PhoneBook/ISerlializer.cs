using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public interface ISerlializer<T>
    {
        void Serialize(T data, IWriter writer);

        void Deserialize(string text);
    }
}
