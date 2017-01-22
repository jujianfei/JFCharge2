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

        public string userlevel(string username) //判断用户类型
        {
            return users.UserLevel(username);
        }

        public bool password(Entity.Login user) //判断用户密码是否正确
        {
            return users.JudgePassword(user);
        }

        public int addusers(Entity.Login user) //添加用户
        {
            return users.AddUsers(user);
        }

        public int deleteusers(Entity.Login user) //删除用户
        {
            return users.DeleteUsers(user);
        }
    }
}
