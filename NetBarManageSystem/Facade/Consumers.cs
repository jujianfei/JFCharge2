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

        public int addconsumers(Entity.Consumers cs) //添加用户
        {
            return CS.AddConsumers(cs);
        }

        public DataTable CheckConsumers() //查询所有消费者信息
        {
            return CS.CheckConsumers();
        }

        public DataTable ReturnConsumeinfo(string cardno) //根据身份证号查询用户信息
        {
            return CS.ReturnConsumerinfo(cardno);
        }

        public int UpdateStatus(string cardno, string status) //更新登录用户的状态信息
        {
            return CS.ModifyUserStatus(cardno, status);
        }

        public int Recharge(string cardno,int money) //消费者充值
        {
            return CS.ConsumerRecharge(cardno, money);
        }

        public string CheckMoney(string cardno) //根据用户id查看消费者余额
        {
            return CS.CheckMoney(cardno);
        }

        public void UpdateMoney(string cardno, int money) //根据用户ID更新消费者余额
        {
            CS.UpdateMoney(cardno,money);
        }
    }
}
