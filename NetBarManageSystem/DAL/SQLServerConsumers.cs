/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/1/22 11:23:21
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class SQLServerConsumers : IDAL.IConsumers
    {
        SQLHelper sqlhelper = null;
        public SQLServerConsumers()
        {
            sqlhelper = new SQLHelper();
        }

        #region 添加消费者用户
        /// <summary>
        /// 添加消费者用户
        /// </summary>
        /// <param name="cs">消费者实体</param>
        /// <returns></returns>
        public int AddConsumers(Entity.Consumers cs)
        {
            //将数据写入到Users表中
            string sql = "insert into Users values('" + cs.cardno + "','" + cs.name + "','" + cs.age + "','" + cs.gender + "','" + cs.money + "','" + cs.status + "','" + cs.sno + "','" + cs.addtime + "')";
            int reslut = sqlhelper.ExecuteNonQuery(sql);
            //将数据插入到注册记录表中
            DateTime dt = DateTime.Now;
            string sno = Entity.GoAnyWhere.id;
            string sql2 = "insert into Register values('"+sno+"','"+dt+"','"+cs.cardno+"','"+cs.money+"')";
            sqlhelper.ExecuteNonQuery(sql2);
            //返回影响的行数
            return reslut;
        }
        #endregion

        #region 查看用户数据
        /// <summary>
        /// 查看用户数据
        /// </summary>
        /// <param name="cardno">消费者身份证号</param>
        /// <returns></returns>
        public DataTable CheckConsumers()
        {
            string sql = "select * from Users";
            return sqlhelper.ExecuteQuery(sql);
        }
        #endregion

        #region 根据消费者身份证号返回一行信息
        /// <summary>
        /// 根据消费者身份证号返回一行信息
        /// </summary>
        /// <param name="cardno">身份证号</param>
        /// <returns></returns>
        public DataTable ReturnConsumerinfo(string cardno)
        {
            string sql = "select * from Users where CardNo='" + cardno + "'";
            return sqlhelper.ExecuteQuery(sql);
        }
        #endregion

        #region 更新登录用户状态信息
        /// <summary>
        /// 更新登录用户状态信息
        /// </summary>
        /// <param name="cardno">用户id</param>
        /// <param name="status">用户状态</param>
        /// <returns></returns>
        public int ModifyUserStatus(string cardno, string status)
        {
            string sql = "update Users set Status='" + status + "' where CardNo='"+cardno+"'";
            return sqlhelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 消费者充值
        /// <summary>
        /// 消费者充值
        /// </summary>
        /// <param name="cardno">身份证号</param>
        /// <param name="money">充值金额</param>
        /// <returns></returns>
        public int ConsumerRecharge(string cardno, int money)
        {
            //查询数据库现有余额
            string sql = "select Money from Users where CardNo='"+cardno+"'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            //现有余额和充值金额相加
            int Smoney = result + money;
            //往充值记录中插入一条充值记录信息
            DateTime time = DateTime.Now;
            string sno = Entity.GoAnyWhere.id;
            string sql3 = "insert into Recharge values('" + cardno + "','" + time + "','" + money + "','" + Smoney + "','" + sno + "')";
            int reslut2 = sqlhelper.ExecuteNonQuery(sql3);
            //将相加后的结果更新到数据库表
            string sql2 = "update Users set Money='" + Smoney + "' where CardNo='" + cardno + "'";
            //返回影响行数信息
            return sqlhelper.ExecuteNonQuery(sql2);
        }
        #endregion
    }
}
