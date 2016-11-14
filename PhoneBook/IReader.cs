﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public interface IReader
    {
        string ReadLine();

        string ReadToEnd();
    }
}
