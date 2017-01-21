﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class SQLServerUsers:IDAL.IUsers
    {
        SQLHelper sqlhelper = null;
        public SQLServerUsers()
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

        #region 判断用户密码是否正确
        /// <summary>
        /// 判断用户密码是否正确
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public bool JudgePassword(Entity.Users user)
        {
            bool flag = false;
            string sql = "select UserName,Password from Login where UserName='" + user.username + "' And Password='" + user.password + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
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
            string sql = "insert into Login values('"+user.username+"','"+user.password+"')";
            int res = sqlhelper.ExecuteNonQuery(sql);
            return res;
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
            string sql = "delete from Login where UserName='"+user.username+"' And Password='"+user.password+"'";
            int res = sqlhelper.ExecuteNonQuery(sql);
            return res;
        }
        #endregion

    }
}
