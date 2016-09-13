using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Model
{
    public class OEMJobTask
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// 任务类名
        /// </summary>
        public string TaskJobClass { get; set; }

        /// <summary>
        /// 任务频率
        /// </summary>
        public string TaskSpeed { get; set; }

        /// <summary>
        /// 任务时间戳
        /// </summary>
        public DateTime? TaskTimeStamp { get; set; }

        /// <summary>
        /// 任务执行最大ID
        /// </summary>
        public int? TaskMaxIdStamp { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        public string TaskDescribe { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
