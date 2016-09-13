using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Data
{
    public static class SqlExtend
    {
        #region 根据DBEntity生产SQL脚本
        /// <summary>
        /// 根据DBEntity生成INSERT脚本
        /// </summary>
        /// <returns></returns>
        public static string GetInsertSql<T>(this T entity, Func<T, object> filter = null)
        {
            var excludeList = new List<string>();//要排除的字段，比如自增列
            if (filter != null)
            {
                excludeList = filter.Invoke(entity).GetType().GetProperties().Select(p => GetColumnName(entity, p.Name)).ToList();
            }
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            PropertyInfo[] propertys = entity.GetType().GetProperties();
            var pList = propertys.Select(p => GetColumnName(entity, p.Name)).Where(n => !excludeList.Contains(n)).ToList();
            builder.AppendFormat("INSERT INTO [dbo].[{0}]", GetTableName(entity));
            builder.AppendFormat("([{0}])", string.Join("],[", pList));
            builder.Append("VALUES");
            builder.AppendFormat("(@{0})", string.Join(",@", pList));
            return builder.ToString();
        }

        /// <summary>
        /// 根据DBEntity生成DELETE脚本
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string GetDeleteSql<T>(this T entity, Func<T, object> filter = null)
        {
            var builder = new StringBuilder();
            builder.AppendFormat("DELETE FROM [dbo].[{0}]", GetTableName(entity));
            if (filter != null)
            {
                var where = filter.Invoke(entity);
                builder.Append(" WHERE  ");
                builder.Append(string.Join(" AND", where.GetType().GetProperties().Select(o => string.Format("[{0}]=@{0}", GetColumnName(entity, o.Name)))));
            }
            return builder.ToString();
        }

        /// <summary>
        /// 根据DBEntity生成UPDATE脚本
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="filter"></param>
        /// <param name="updater"></param>
        /// <returns></returns>
        public static string GetUpdateSql<T>(this T entity, Func<T, object> filter, Func<T, object> updater = null)
        {
            if (entity == null || filter == null)
                throw new ArgumentException();
            if (updater == null) updater = o => o;
            var where = filter.Invoke(entity);
            var paramters = updater.Invoke(entity);
            if (paramters.GetType().GetProperties().Length == 0)
                throw new ArgumentException();

            var builder = new StringBuilder();
            builder.AppendFormat("UPDATE [dbo].[{0}] SET ", GetTableName(entity));
            builder.Append(string.Join(",", paramters.GetType().GetProperties().Select(o => string.Format("[{0}]=@{0}", GetColumnName(entity, o.Name)))));
            builder.Append(" WHERE  ");
            builder.Append(string.Join(" AND", where.GetType().GetProperties().Select(o => string.Format("[{0}]=@{0}", GetColumnName(entity, o.Name)))));
            return builder.ToString();
        }

        /// <summary>
        /// 根据DBEntity生成SELECT脚本
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string GetSelectSql<T>(this T entity, Func<T, object> filter = null, Func<T, object> sort = null, Func<T, Object> selectFilter = null)
        {
            if (entity == null)
                throw new ArgumentException();
            var builder = new StringBuilder();
            builder.AppendFormat("SELECT top 10 ");
            if (selectFilter == null)
            {
                builder.Append(string.Join(",", entity.GetType().GetProperties().Select(o => string.Format("[{0}]", GetColumnName(entity, o.Name)))));
            }
            else
            {
                var selectColumn = selectFilter(entity);
                builder.Append(string.Join(",", selectColumn.GetType().GetProperties().Select(o => string.Format("[{0}]", GetColumnName(entity, o.Name)))));

            }
            builder.AppendFormat(" FROM [dbo].[{0}] WITH(NOLOCK)", GetTableName(entity));
            if (filter != null)
            {//拼条件
                var where = filter.Invoke(entity);
                builder.Append(" WHERE ");
                if (where.ToString().ToUpper().Contains("ID") && !where.ToString().ToUpper().Contains("TASKID"))
                {
                    builder.Append(string.Join(" AND", where.GetType().GetProperties().Select(o => string.Format("[{0}]>@{0}", GetColumnName(entity, o.Name)))));
                }
                else
                {
                    builder.Append(string.Join(" AND", where.GetType().GetProperties().Select(o => string.Format("[{0}]=@{0}", GetColumnName(entity, o.Name)))));
                }
            }
            if (sort != null)
            {//拼排序
                var objSort = sort.Invoke(entity);
                builder.AppendFormat(" ORDER BY {0} ASC", string.Join(",", objSort.GetType().GetProperties().Select(o => string.Format("{0}", GetColumnName(entity, o.Name)))));
            }
            return builder.ToString();
        }


        /// <summary>
        /// 根据DBEntity生成SELECT脚本,有分页功能
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public static string GetSelectSqlWithPaging<T>(this T entity, Func<T, object> filter, Func<T, object> sort = null, int pageIndex = 1, int pageSize = 10)
        {
            if (entity == null || filter == null)
                throw new ArgumentException();
            var where = filter.Invoke(entity);
            var builder = new StringBuilder();
            builder.AppendFormat("SELECT ");
            builder.Append(string.Join(",", entity.GetType().GetProperties().Select(o => string.Format("[{0}]", GetColumnName(entity, o.Name)))));
            builder.AppendFormat(" FROM [dbo].[{0}] WITH(NOLOCK) WHERE  ", GetTableName(entity));
            builder.Append(string.Join(" AND", where.GetType().GetProperties().Select(o => string.Format("[{0}]=@{0}", GetColumnName(entity, o.Name)))));
            if (sort != null)
            {
                var objSort = sort.Invoke(entity);
                builder.AppendFormat(" ORDER BY {0} DESC", string.Join(",", objSort.GetType().GetProperties().Select(o => string.Format("{0}", GetColumnName(entity, o.Name)))));
            }
            builder.AppendFormat(" offset ({0}-1)*{1} rows fetch next {1} rows only", pageIndex, pageSize);
            return builder.ToString();
        }

        /// <summary>
        /// 获取映射的表名
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string GetTableName(object entity)
        {
            Type t = entity.GetType();
            TableAttribute ta = t.GetCustomAttribute<TableAttribute>();
            if (ta != null)
            {
                return ta.Name;
            }
            return t.Name;
        }

        /// <summary>
        /// 获取映射的列名
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string GetColumnName(object entity, string name)
        {
            MemberInfo[] memInfo = entity.GetType().GetMember(name);
            if (memInfo != null && memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes<ColumnAttribute>();
                if (attrs != null && attrs.Any())
                {
                    return attrs.First().Name;
                }
            }
            return name;
        }
        #endregion
    }
}
