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

namespace DAL
{
    public class SQLServerConsumers:IDAL.IConsumers
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
            string sql = "insert into Users values('" + cs.cardno + "','" + cs.name + "','" + cs.age + "','" + cs.gender + "','" + cs.money + "','" + cs.status + "','" + cs.sno + "','" + cs.addtime + "')";
            int res = sqlhelper.ExecuteNonQuery(sql);
            return res;
        }
        #endregion
    }
}
