using Jinri.Zonefare.Model.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace Jinri.Zonefare.Data.Supplier
{
    public class SupplierDal
    {
        /// <summary>
        /// 获取国际平台供应商数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static IList<tblInterUser> GetTblInterUserData(tblInterUser model)
        {
            string sql = model.GetSelectSql<tblInterUser>(w => new { w.id }, s => new { s.id });

            using (SqlConnection conn = new SqlConnection(ConnectionString.JinriAirV2DB_SELECT))
            {
                conn.Open();
                return conn.Query<tblInterUser>(sql, model).ToList();
            }
        }

        /// <summary>
        /// 获取国际平台供应商拓展表实体
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static tblInterUserExt GettblInterUserExtEntity(tblInterUserExt model)
        {
            string sql = model.GetSelectSql<tblInterUserExt>(w => new { w.UserName });

            using (SqlConnection conn = new SqlConnection(ConnectionString.JinriAirV2DB_SELECT))
            {
                conn.Open();
                var list = conn.Query<tblInterUserExt>(sql, model).ToList();
                return list != null && list.Count > 0 ? list[0] : null;
            }
        }

        /// <summary>
        /// 将供应商数据写入海外数据库
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool InsertTblInterUserData(tblInterUser model)
        {
            string sqlExist = string.Format("select id from tblInterUser with(nolock) where username='{0}'", model.username);
            string sqlInsert = model.GetInsertSql<tblInterUser>(o => new { o.id });
            string sqlUpdate = model.GetUpdateSql<tblInterUser>(o => new { o.username }, u => new { u.WorkTime, u.WorkTimetxtend, u.worktimetxtens });
            string sql = string.Format("if exists({0}) {1} else {2}", sqlExist, sqlUpdate, sqlInsert);

            using (SqlConnection conn = new SqlConnection(ConnectionString.ZonefareAirV2DB_INSERT))
            {
                conn.Open();
                return conn.Execute(sql, model) > 0;
            }
        }

        /// <summary>
        /// 将供应商拓展表数据写入海外数据库
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public static bool InsertTblInterUserExtData(tblInterUserExt model)
        {
            string sqlExist = string.Format("select username from tblInterUserExt  with(nolock)  where username='{0}'", model.UserName);
            string sqlInsert = model.GetInsertSql<tblInterUserExt>();
            sqlInsert += ";SELECT 1";
            string sql = string.Format("if exists({0}) select 0 else {1}", sqlExist, sqlInsert);

            using (SqlConnection conn = new SqlConnection(ConnectionString.ZonefareAirV2DB_INSERT))
            {
                conn.Open();
                int rowsAffectd = conn.Query<int>(sql, model).Single();
                return rowsAffectd > 0;
            }
        }


    }
}
