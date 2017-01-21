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

        public bool password(Entity.Users user) //判断用户密码是否正确
        {
            return users.JudgePassword(user);
        }

        public int addusers(Entity.Users user) //添加用户
        {
            return users.AddUsers(user);
        }

        public int deleteusers(Entity.Users user) //删除用户
        {
            return users.DeleteUsers(user);
        }
    }
}
