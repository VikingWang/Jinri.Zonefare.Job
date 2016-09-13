using Jinri.Zonefare.Common;
using Jinri.Zonefare.Data.Supplier;
using Jinri.Zonefare.Model.Supplier;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Business.Supplier
{
    public class SupplierBll
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("log4net.config");
        /// <summary>
        /// 具体业务处理方法
        /// </summary>
        public void Process()
        {
            logger.Info("执行用户查询开始........");
            tblInterUser entity = new tblInterUser();
            var jobEntity = new OEMJobTaskBll().GetOEMJobTaskEntity(new Model.OEMJobTask() { TaskId = "T001" });
            if (jobEntity != null)
            {
                entity.id = Convert.ToInt32(jobEntity.TaskMaxIdStamp);
            }
            else
            {
                entity.id = Convert.ToInt32(ConfigurationManager.AppSettings["SupplierId"]);
            }
            var lstUser = SupplierDal.GetTblInterUserData(entity);
            logger.Info("执行用户查询结束，总记录数：" + lstUser.Count);
            bool bSuccess = false;
            int iAddId = 0;
            foreach (var model in lstUser)
            {
                bSuccess = SupplierDal.InsertTblInterUserData(model);
                iAddId = model.id;
                if (bSuccess)
                {
                    var userEx = SupplierDal.GettblInterUserExtEntity(new tblInterUserExt() { UserName = model.username });
                    if (userEx != null)
                    {
                        SupplierDal.InsertTblInterUserExtData(userEx);
                    }
                }
                logger.Info(string.Format("TaskMaxIdStamp更新为：{0}", iAddId));
            }

            bool bRes = new OEMJobTaskBll().UpdateOEMJobTaskEntity(new Model.OEMJobTask() { TaskId = "T001", TaskMaxIdStamp = iAddId, CreateTime = DateTime.Now });
            logger.Info(string.Format("TaskMaxIdStamp更新{0}", bRes?"成功":"失败"));
            logger.Info("处理所有用户结束.....");
        }
    }
}
