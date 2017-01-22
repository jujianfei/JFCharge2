/*
 * ==================
 * 创建人：琚建飞
 * 创建时间：2017/1/22 11:28:56
 * 说明：
 * ==================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Consumers
    {
        BLL.Consumers consumers;
        public Consumers()
        {
            consumers = new BLL.Consumers();
        }

        public int addconsumers(Entity.Consumers cs) //添加用户
        {
            return consumers.AddConsumers(cs);
        }
    }
}
