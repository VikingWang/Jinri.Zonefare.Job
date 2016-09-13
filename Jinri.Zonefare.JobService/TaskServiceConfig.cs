using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Jinri.Zonefare.JobService
{
    public class TaskServiceConfig
    {
        List<string[]> TaskList = new List<string[]>();

        public TaskServiceConfig()
        {
            TaskList.Add(new string[3] { "T001", "SupplierAutoJob", ConfigurationManager.AppSettings["SupplierTask"].ToString() });//供应商数据同步
        }
        #region 获取需要所有需要运行的任务
        /// <summary>
        /// 获取需要所有需要运行的任务
        /// </summary>
        /// <returns></returns>
        public IList<Hashtable> GetAllRunForTask()
        {
            IList<Hashtable> returnList = new List<Hashtable>();

            Hashtable htResult;
            if (TaskList != null)
            {
                foreach (string[] dr in TaskList)
                {
                    htResult = new Hashtable();
                    htResult.Add("TASK_ID", dr[0]);
                    htResult.Add("LOCATION_TASK", dr[1]);
                    htResult.Add("INTERVAL", dr[2]);
                    returnList.Add(htResult);
                }
            }
            return returnList;
        }
        #endregion
    }
}
