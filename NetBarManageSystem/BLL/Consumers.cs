/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/1/22 11:26:32
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Consumers
    {
        #region 添加消费者用户
        /// <summary>
        /// 添加消费者用户
        /// </summary>
        /// <param name="cs">消费者实体</param>
        /// <returns></returns>
        public int AddConsumers(Entity.Consumers cs)
        {
            IDAL.IConsumers ic = Factory.DataAccess.Consumers();
            int result= ic.AddConsumers(cs);
            return result;
        }
        #endregion
    }
}
