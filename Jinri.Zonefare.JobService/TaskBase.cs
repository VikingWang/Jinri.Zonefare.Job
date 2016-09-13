using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jinri.Zonefare.JobService
{
    public class TaskBase
    {
        #region Attributes
        /// <summary>
        /// 执行类类名
        /// </summary>
        protected string LOCATION_TASK { get; set; }

        /// <summary>
        /// 相关业务表名
        /// </summary>
        protected string BusinessTable { set; get; }

        /// <summary>
        /// 任务ID
        /// </summary>
        private string taskId;
        #endregion

        #region Task执行接口,入口方法
        /// <summary>
        /// Task执行接口,入口方法
        /// </summary>
        /// <param name="TaskID">任务ID</param>
        public virtual void Execute(long TaskID, string taskname)
        {

        }

        #endregion
    }
}
