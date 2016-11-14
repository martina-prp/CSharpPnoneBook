﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public interface ISerlializer<T>
    {
        string Serialize(T data);

        void Deserialize(string text);
    }
}
