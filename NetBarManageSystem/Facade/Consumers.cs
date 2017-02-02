/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/1/22 11:28:56
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Consumers
    {
        BLL.Consumers CS;
        public Consumers()
        {
            CS = new BLL.Consumers();
        }

        #region 添加用户
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="cs"></param>
        /// <returns></returns>
        public int addconsumers(Entity.Consumers cs) 
        {
            return CS.AddConsumers(cs);
        }
        #endregion

        #region 查询所有消费者信息
        /// <summary>
        /// 查询所有消费者信息
        /// </summary>
        /// <returns></returns>
        public DataTable CheckConsumers() 
        {
            return CS.CheckConsumers();
        }
        #endregion

        #region  根据身份证号查询用户信息
        /// <summary>
        /// 根据身份证号查询用户信息
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public DataTable ReturnConsumeinfo(string cardno) 
        {
            return CS.ReturnConsumerinfo(cardno);
        }
        #endregion

        #region 更新登录用户的状态信息
        /// <summary>
        /// 更新登录用户的状态信息
        /// </summary>
        /// <param name="cardno"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public int UpdateStatus(string cardno, string status) 
        {
            return CS.ModifyUserStatus(cardno, status);
        }
        #endregion

        #region 消费者充值
        /// <summary>
        /// 消费者充值
        /// </summary>
        /// <param name="cardno"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int Recharge(string cardno,int money) 
        {
            return CS.ConsumerRecharge(cardno, money);
        }
        #endregion

        #region 根据用户id查看消费者余额并进行减一更新
        /// <summary>
        /// 根据用户id查看消费者余额并进行减一更新
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public string CheckMoney(string cardno) 
        {
            return CS.CheckMoney(cardno);
        }
        #endregion

        #region 根据用户id查看用户余额
        /// <summary>
        /// 根据用户id查看用户余额
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public string LookMoney(string cardno)
        {
            return CS.LookMoney(cardno);
        }
        #endregion

        #region 根据用户ID更新消费者余额
        /// <summary>
        /// 根据用户ID更新消费者余额
        /// </summary>
        /// <param name="cardno"></param>
        /// <param name="money"></param>
        public void UpdateMoney(string cardno, int money) 
        {
            CS.UpdateMoney(cardno,money);
        }
        #endregion

        #region 用户下机，向消费记录表中插入一条信息
        /// <summary>
        /// 用户下机，向消费记录表中插入一条信息
        /// </summary>
        /// <param name="money"></param>
        public void InsertConsumeInfo(Entity.Money money) 
        {
            CS.InsertConsumeInfo(money);
        }
        #endregion

        #region 根据用户id查询消费记录
        /// <summary>
        /// 根据用户id查询消费记录
        /// </summary>
        /// <param name="cardno"></param>
        /// <returns></returns>
        public DataTable CheckConsumeInfo(string cardno) 
        {
            return CS.CheckConsumeInfo(cardno);
        }
        #endregion

        #region 添加一行退卡信息
        /// <summary>
        /// 添加一行退卡信息
        /// </summary>
        /// <param name="backinfo"></param>
        /// <returns></returns>
        public int AddBackInfo(Entity.BackMoney backinfo)
        {
            return CS.AddBackInfo(backinfo);
        }
        #endregion

        #region 返回一张退卡信息
        /// <summary>
        /// 返回一张退卡信息
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnBackInfo()
        {
            return CS.ReturnBackInfo();
        }
        #endregion

        #region 返回一张注册信息表
        /// <summary>
        /// 返回一张注册信息表
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnRegister()
        {
            return CS.ReturnRegister();
        }
        #endregion

        #region 返回一张充值信息记录表
        /// <summary>
        /// 返回一张充值信息记录表
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnRecharge()
        {
            return CS.ReturnRecharge();
        }
        #endregion

        #region 获取注册表中注册的金额总数
        /// <summary>
        /// 获取注册表中注册的金额总数
        /// </summary>
        /// <returns></returns>
        public int ReturnRegisterSum()
        {
            return CS.ReturnRegisterSum();
        }
        #endregion

        #region 获取退款表中注册的金额总数
        /// <summary>
        /// 获取退款表中注册的金额总数
        /// </summary>
        /// <returns></returns>
        public int ReturnBackSum()
        {
            return CS.ReturnBackSum();
        }
        #endregion

        #region 获取充值表中注册的金额总数
        /// <summary>
        /// 获取充值表中注册的金额总数
        /// </summary>
        /// <returns></returns>
        public int ReturnRechargeSum()
        {
            return CS.ReturnRechargeSum();
        }
        #endregion
    }
}
