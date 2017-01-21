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
            IDAL.IUsers iu = Factory.DataAccess.Users();
            bool result = iu.SelectUser(username);
            return result;
        }
        #endregion

        #region 判断用户密码是否正确
        /// <summary>
        /// 判断用户密码是否正确
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public bool JudgePassword(Entity.Users user)
        {
            IDAL.IUsers iu = Factory.DataAccess.Users();
            bool result = iu.JudgePassword(user);
            return result;
        }
        #endregion
        
        #region 添加新用户
        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int AddUsers(Entity.Users user)
        {
            IDAL.IUsers iu = Factory.DataAccess.Users();
            int result = iu.AddUsers(user);
            return result;
        }
        #endregion

         #region 删除用户
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int DeleteUsers(Entity.Users user)
        {
            IDAL.IUsers iu = Factory.DataAccess.Users();
            int result = iu.DeleteUsers(user);
            return result;
        }
        #endregion
    }
}
