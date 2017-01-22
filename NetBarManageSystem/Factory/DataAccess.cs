using IDAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Factory
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "DAL"; //程序集名称，即这个类所在的根文件名称
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IDAL.IUsers Users()
        {
            string className = AssemblyName + "." +db+"Users";
            return (IDAL.IUsers)Assembly.Load(AssemblyName).CreateInstance(className); 
        }

        public static IDAL.IConsumers Consumers()
        {
            string className = AssemblyName + "." + db + "Consumers";
            return (IDAL.IConsumers)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
