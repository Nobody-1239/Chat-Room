using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace chatroom
{
    internal interface I_SignUp
    {
        bool SignUp(string username, string password, string Email);
        bool Check_Repitive(string username);
    }
}
