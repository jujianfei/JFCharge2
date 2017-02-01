/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017年1月26日12:10:40
 * 说明：登录用户相关类
 * ==================
 */
using System;
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

        #region 判断用户类型
        /// <summary>
        /// 判断用户类型
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public string UserLevel(string username)
        {
            string sql = "select Level from Login where UserName='"+username+"'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return Convert.ToString(dt.Rows[0][0]);
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
            string sql = "select UserName,Password,Status from Login where UserName='" + user.username + "' And Password='" + user.password + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToString(dt.Rows[0][2]);
            }
            return Convert.ToString(false);
        }
        #endregion

        #region 添加新登录用户
        /// <summary>
        /// 添加新登录用户
        /// </summary>
        /// <param name="user">登录用户实体</param>
        /// <returns></returns>
        public int AddUsers(Entity.Login user)
        {
            string sql = "insert into Login values('" + user.username + "','" + user.password + "','" + user.level + "','" + user.status + "')";
            int res = sqlhelper.ExecuteNonQuery(sql);
            return res;
        }
        #endregion

        #region 删除登录用户
        /// <summary>
        /// 删除登录用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int DeleteUsers(Entity.Login user)
        {
            string sql = "delete from Login where UserName='"+user.username+"' And Password='"+user.password+"'";
            int res = sqlhelper.ExecuteNonQuery(sql);
            return res;
        }
        #endregion

    }
}
