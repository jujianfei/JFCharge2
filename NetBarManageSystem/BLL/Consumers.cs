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
using System.Data;

namespace BLL
{
    public class Consumers
    {
        IDAL.IConsumers ic;
        public Consumers()
        {
            ic = Factory.DataAccess.Consumers();
        }
        #region 添加消费者用户
        /// <summary>
        /// 添加消费者用户
        /// </summary>
        /// <param name="cs">消费者实体</param>
        /// <returns></returns>
        public int AddConsumers(Entity.Consumers cs)
        {
            return ic.AddConsumers(cs);
        }
        #endregion

        #region  查询所有消费者信息
        /// <summary>
        /// 查询所有消费者信息
        /// </summary>
        /// <returns></returns>
        public DataTable CheckConsumers()
        {
            return ic.CheckConsumers();
        }
        #endregion

        #region 根据用户id查看用户余额
        /// <summary>
        /// 根据用户id查看用户余额
        /// </summary>
        /// <param name="cardno">用户id</param>
        /// <returns></returns>
        public string CheckMoney(string cardno)
        {
            return ic.CheckMoney(cardno);
        }
        #endregion

         #region 根据用户id更新用户余额
        /// <summary>
        /// 根据用户id更新用户余额
        /// </summary>
        /// <param name="cardno">用户id</param>
        /// <param name="money">最新余额</param>
        public void UpdateMoney(string cardno, int money)
        {
             ic.UpdateMoney(cardno,money);
        }
        #endregion

        #region 根据身份证号返回一行信息
        /// <summary>
        /// 根据身份证号返回一行信息
        /// </summary>
        /// <param name="cardno">身份证号</param>
        /// <returns></returns>
        public DataTable ReturnConsumerinfo(string cardno)
        {
            return ic.ReturnConsumerinfo(cardno);
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
            return ic.ModifyUserStatus(cardno,status);
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
            return ic.ConsumerRecharge(cardno,money);
        }
        #endregion
    }
}
