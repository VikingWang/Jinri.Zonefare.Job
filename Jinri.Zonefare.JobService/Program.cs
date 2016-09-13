using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.JobService
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new JobService() 
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
