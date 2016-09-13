using Jinri.Zonefare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Business
{
    public class OEMJobTaskBll
    {
        private Jinri.Zonefare.Data.OEMJobTaskDal jobDal = new Data.OEMJobTaskDal();
        /// <summary>
        /// 获取OEMJOB任务列表
        /// </summary>
        /// <param name="model">TaskId</param>
        /// <returns></returns>
        public OEMJobTask GetOEMJobTaskEntity(OEMJobTask model)
        {
           return  jobDal.GetOEMJobTaskEntity(model);
        }

        /// <summary>
        /// 更新OEMJOB任务实体
        /// </summary>
        /// <param name="model">TaskId/TaskMaxIdStamp/TaskTimeStamp/CreateTime</param>
        /// <returns></returns>
        public bool UpdateOEMJobTaskEntity(OEMJobTask model)
        {
            return jobDal.UpdateOEMJobTaskEntity(model);
        }
    }
}
