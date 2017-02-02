using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class LoginUsers
    {
        IDAL.IUsers iu;
        public LoginUsers()
        {
            iu = Factory.DataAccess.Users();
        }

        #region 判断用户是否存在
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool SelectUser(string username)
        {
            return iu.SelectUser(username);
        }
        #endregion

        #region 判断用户密码是否正确，并返回状态信息
        /// <summary>
        /// 判断用户密码是否正确，并返回状态信息
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public string JudgePassword(Entity.Login user)
        {
            return iu.JudgePassword(user);
        }
        #endregion

        #region 判断用户类型
        /// <summary>
        /// 判断用户类型
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public string UserLevel(string username)
        {
            return iu.UserLevel(username);
        }
        #endregion

        #region 添加新用户
        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int AddUsers(Entity.Login user)
        {
            return iu.AddUsers(user);
        }
        #endregion

        #region 删除用户
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int DeleteUsers(Entity.Login user)
        {
            return iu.DeleteUsers(user);
        }
        #endregion

    }
}
