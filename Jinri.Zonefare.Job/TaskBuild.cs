using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Job
{
    public class TaskBuild : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            //获取执行参数
            JobDataMap data = context.JobDetail.JobDataMap;
            long jobname = data.GetLong("JOB_NAME");
            string wsClassName = data.GetString("LOCATION_TASK");
            string taskId = data.GetString("TASK_ID");

            //反射创建类
            Assembly asm = AppDomain.CurrentDomain.Load("Jinri.Zonefare.Job");
            var bllObject = (TaskBase)asm.CreateInstance("Jinri.Zonefare.Job.JobTasks" + "." + wsClassName);
            if (bllObject == null)
            {
               // TaskLog.Log.Info(string.Format("错误: 任务[{0}], 任务类 [{1}] 未成功创建.", taskId, wsClassName));
                return;
            }

            //执行业务类方法
            //TaskLog.Log.Info(string.Format("开始执行任务[{0}], 任务类 [{1}], 任务名称 [{2}]...", taskId, wsClassName, jobname));
            bllObject.Execute(jobname, taskId);
           // TaskLog.Log.Info(string.Format("任务[{0}]执行完毕.", taskId));
        }
    }
}
