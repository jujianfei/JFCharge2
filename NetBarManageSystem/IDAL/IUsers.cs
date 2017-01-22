using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDAL
{
     public interface IUsers
    {
        bool SelectUser(string username); //判断用户名是否存在
        string UserLevel(string username); //判断用户类型
        bool JudgePassword(Entity.Login user);//判断密码是否正确
        int AddUsers(Entity.Login user); //添加登录用户
        int DeleteUsers(Entity.Login user); //删除登录用户
    }
}
