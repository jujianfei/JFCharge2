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
            IDAL.IUsers iu = Factory.DataAccess.CreateUser();
            bool result = iu.SelectUser(username);
            return result;
        }
        #endregion

    }
}
