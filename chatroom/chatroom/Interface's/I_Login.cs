﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace chatroom
{
    internal interface I_Login
    {
        bool Login(string username, string password);
    }
}
