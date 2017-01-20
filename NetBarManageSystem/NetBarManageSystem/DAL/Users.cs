using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Users
    {
        SQLHelper sqlhelper = null;
        public Users()
        {
            sqlhelper = new SQLHelper();
        }

        #region 判断用户是否存在
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool SelectUser(string username)
        {
            bool flag = false;
            string sql = "select UserName from Login where UserName='" + username + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            if (dt.Rows.Count>0)
            {
                flag = true;
            }
            return flag;
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
            bool flag = false;
            string sql = "select UserName,Password from Login where UserName='" + user.username + "' AND Password='"+user.password+"'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            if (dt.Rows.Count>0)
            {
                flag = true;
            }
            return flag;
        }
         #endregion
    }
}
