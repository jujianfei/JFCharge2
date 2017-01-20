using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class Users
    {
        #region 判断用户是否存在
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool SelectUser(string username)
        {
                DAL.Users user = new DAL.Users();  
                bool result = user.SelectUser(username);
                return result;
        }
        #endregion

        #region 判断用户是否存在
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool JudgePassword(Entity.Users user)
        {
            DAL.Users users = new DAL.Users();
            return users.JudgePassword(user);
        }
        #endregion
    }
}
