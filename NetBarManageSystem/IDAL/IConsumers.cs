using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace IDAL
{
    public interface IConsumers
    {
        int AddConsumers(Entity.Consumers cs); //添加消费用户接口
        DataTable CheckConsumers();//查询所有消费者信息
        DataTable ReturnConsumerinfo(string cardno);//根据用户身份证号返回一行信息
        int ModifyUserStatus(string cardno, string status); //更新登录用户状态信息
        int ConsumerRecharge(string cardno, int money);//消费者充值
        string CheckMoney(string cardno); //根据用户id查看用户余额并进行减1更新
        void UpdateMoney(string cardno,int money);// 根据用户id修改用户余额
        void InsertConsumeInfo(Entity.Money money);//用户下机，向消费记录表中插入一条信息
        DataTable CheckConsumeInfo(string cardno);//根据用户id查询消费记录信息
        string LookMoney(string cardno);//根据用户id查询消费者余额
        int AddBackInfo(Entity.BackMoney backinfo);//插入一行用户退卡信息
        DataTable ReturnBackInfo();//返回一张退卡信息表
        DataTable ReturnRegister();//返回一张注册信息记录表
        DataTable ReturnRecharge();//返回一张充值记录表
        int ReturnRegisterSum();//返回注册表注册金额的总数
        int ReturnBackSum();//返回退款表中金额的总数
        int ReturnRechargeSum();//返回充值表中金额的总数
    }
}
