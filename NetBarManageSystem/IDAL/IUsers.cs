using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
     public interface IUsers
    {
        bool SelectUser(string username);
        bool JudgePassword(Entity.Users user);
        int AddUsers(Entity.Users user);
        int DeleteUsers(Entity.Users user);
    }
}
