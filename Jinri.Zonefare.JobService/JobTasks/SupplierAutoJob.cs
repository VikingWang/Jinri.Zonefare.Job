using Jinri.Zonefare.Business.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.JobService.JobTasks
{
   public  class SupplierAutoJob:TaskBase
    {
        public override void Execute(long TaskID, string taskname)
        {
            new SupplierBll().Process();
        }
    }
}
