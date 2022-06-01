using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanaCrawler
{
    internal class LogUtil
    {
        private static readonly ILog log = LogManager.GetLogger("DanaCrawler");

        public static void LogInfo(string Message)
        {
            log.Info(Message);
        }
    }
}
