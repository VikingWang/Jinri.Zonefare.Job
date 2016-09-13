using Jinri.Zonefare.Business;
using Jinri.Zonefare.Business.Supplier;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Job.JobTasks
{
    /// <summary>
    /// 同步供应商数据
    /// </summary>
    public class SupplierAutoJob : TaskBase
    {
        public override void Execute(long TaskID, string taskname)
        {
            new SupplierBll().Process();
        }
    }
}
