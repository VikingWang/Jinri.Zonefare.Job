using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.JobService
{
    public partial class JobService : ServiceBase
    {
        private readonly ILog logger;
        private IScheduler scheduler;
        public JobService()
        {
            logger = LogManager.GetLogger(this.GetType());
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            scheduler = schedulerFactory.GetScheduler();
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            #region 添加任务进调度器

            logger.Info("Quartz服务启动...");
            logger.Info("获取任务列表...");

            //获取所有任务列表
            IList<Hashtable> syncList;
            try
            {
                syncList = new TaskServiceConfig().GetAllRunForTask();
            }
            catch (Exception ex)
            {
                logger.Info("错误: 获取任务列表出错, 错误信息: " + ex.Message);
                return;
            }
            logger.Info("任务数量: " + syncList.Count);

            int i = 0;
            foreach (Hashtable sync in syncList)
            {
                //任务ID
                i++;
                string taskId = "Task" + i;

                //添加任务
                IJobDetail job = JobBuilder.Create<TaskBuild>().WithIdentity(taskId, "Group1").Build();

                //任务参数               
                job.JobDataMap.Put("TASK_ID", taskId);
                job.JobDataMap.Put("LOCATION_TASK", sync["LOCATION_TASK"]);

                string interval = sync["INTERVAL"] == null ? "" : sync["INTERVAL"].ToString();
                if (string.IsNullOrEmpty(interval))
                {
                    interval = "0/59 * * * * ?";
                }
                //创建触发器
                ICronTrigger trigger = (ICronTrigger)TriggerBuilder.Create()
                .WithIdentity("Trigger" + i, "Group1")
                .WithCronSchedule(interval)
                .Build();

                //将任务加入调度器
                scheduler.ScheduleJob(job, trigger);

                logger.Info(string.Format("任务{0}: 执行类:[{1}], 运行间隔:[{2}] ] 添加至Quartz调度器.", taskId, sync["LOCATION_TASK"], interval));
            }
            #endregion

            #region 启动Quartz调度器
            scheduler.Start();
            logger.Info("Quartz服务成功启动.");
            #endregion
        }

        protected override void OnStop()
        {
            logger.Info("Job服务停止...");
        }
    }
}
