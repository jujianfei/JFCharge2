using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SQLHelper
    {
        SqlConnection conn = null;
        public SQLHelper()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString; //获取配置文件中的连接字符串
            conn = new SqlConnection(connStr);
        }

        #region 该方法执行传入的查询SQL语句
        /// <summary>
        /// 该方法执行传入的查询SQL语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回查询的结果表</returns>
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader();// 返回一个dataReader,把cmd查询的结果放到sdr里面
            dt.Load(sdr); //把sdr的内容装到dt里面
            sdr.Close();
            conn.Close();
            return dt;
        }
        #endregion

        #region 该方法执行传入的增删改SQL语句
        /// <summary>
        /// 该方法执行传入的增删改SQL语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回更新的记录数</returns>
        public int ExecuteNonQuery(string sql)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }
        #endregion
    }
}
