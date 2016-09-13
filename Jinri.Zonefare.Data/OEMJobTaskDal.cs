using Jinri.Zonefare.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Jinri.Zonefare.Data
{
    public class OEMJobTaskDal
    {
        /// <summary>
        /// 获取OEMJOB任务列表
        /// </summary>
        /// <param name="model">TaskId</param>
        /// <returns></returns>
        public OEMJobTask GetOEMJobTaskEntity(OEMJobTask model)
        {
            string sql = model.GetSelectSql<OEMJobTask>(w => new { w.TaskId });

            using (SqlConnection conn = new SqlConnection(ConnectionString.IFltZonefareDB_SELECT))
            {
                conn.Open();
                var list = conn.Query<OEMJobTask>(sql, model).ToList();
                return list != null ? list[0] : null;
            }
        }

        /// <summary>
        /// 更新OEMJOB任务实体
        /// </summary>
        /// <param name="model">TaskId/TaskMaxIdStamp/TaskTimeStamp/CreateTime</param>
        /// <returns></returns>
        public bool UpdateOEMJobTaskEntity(OEMJobTask model)
        {
            model.TaskTimeStamp = DateTime.Now;
            string sql = model.GetUpdateSql<OEMJobTask>(w => new { w.TaskId }, u => new { u.TaskMaxIdStamp, u.TaskTimeStamp, u.CreateTime });

            using (SqlConnection conn = new SqlConnection(ConnectionString.IFltZonefareDB_INSERT))
            {
                conn.Open();
                return conn.Execute(sql, model) > 0;
            }
        }
    }
}
