﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Contracts
{
    public interface IPhoneBookParser
    {
        PhoneBook ParseData(IReader reader);
    }
}
