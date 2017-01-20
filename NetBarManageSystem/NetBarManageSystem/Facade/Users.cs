using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Users
    {
        BLL.Users users;
        public Users()
        {
            users = new BLL.Users();
        }
        public bool username(string username) //判断用户是否存在
        {
            return users.SelectUser(username);
        }
        public bool Password(Entity.Users user)//判断用户密码是否正确
        {
            return users.JudgePassword(user);
        }
    }
}
