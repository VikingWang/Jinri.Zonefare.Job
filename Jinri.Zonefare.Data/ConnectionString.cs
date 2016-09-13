using JFx;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Data
{
    public class ConnectionString
    {
        //配置
        static string encryptKey = ConfigurationManager.AppSettings["EncryptKey"];

        #region JinTongDB

        #region JinriAirV2DB
        private static string m_JinriAirV2DB_SELECT;

        /// <summary>
        /// JinTong V2库只读连接
        /// </summary>
        public static string JinriAirV2DB_SELECT
        {
            get
            {
                if (string.IsNullOrEmpty(m_JinriAirV2DB_SELECT))
                {
                    m_JinriAirV2DB_SELECT = JinRiEncryptTool.Decrypt(ConfigurationManager.ConnectionStrings["JinriAirV2DB_SELECT"].ConnectionString, encryptKey);
                }
                return m_JinriAirV2DB_SELECT;
            }
        }
        #endregion

        #region JinriDB
        private static string m_JinriDB_SELECT;

        /// <summary>
        /// JinTong V2库只读连接
        /// </summary>
        public static string JinriDB_SELECT
        {
            get
            {
                if (string.IsNullOrEmpty(m_JinriDB_SELECT))
                {
                    m_JinriDB_SELECT = JinRiEncryptTool.Decrypt(ConfigurationManager.ConnectionStrings["JinriDB_SELECT"].ConnectionString, encryptKey);
                }
                return m_JinriDB_SELECT;
            }
        }
        #endregion

        #endregion

        #region ZonefareDB

        #region JinriAirV2DB
        private static string m_ZonefareAirV2DB_INSERT;

        /// <summary>
        /// Zonefare V2库写连接
        /// </summary>
        public static string ZonefareAirV2DB_INSERT
        {
            get
            {
                if (string.IsNullOrEmpty(m_ZonefareAirV2DB_INSERT))
                {
                    m_ZonefareAirV2DB_INSERT = JinRiEncryptTool.Decrypt(ConfigurationManager.ConnectionStrings["ZonefareAirV2DB_INSERT"].ConnectionString, encryptKey);
                }
                return m_ZonefareAirV2DB_INSERT;
            }
        }
        #endregion

        #region JinriDB
        private static string m_ZonefareJinriDB_INSERT;

        /// <summary>
        /// Zonefare V2库写连接
        /// </summary>
        public static string ZonefareJinriDB_INSERT
        {
            get
            {
                if (string.IsNullOrEmpty(m_ZonefareAirV2DB_INSERT))
                {
                    m_ZonefareJinriDB_INSERT = JinRiEncryptTool.Decrypt(ConfigurationManager.ConnectionStrings["ZonefareJinriDB_INSERT"].ConnectionString, encryptKey);
                }
                return m_ZonefareJinriDB_INSERT;
            }
        }
        #endregion

        #region IFltZonefareDB 系统主数据库

        private static string m_IFltZonefareDB_SELECT;

        /// <summary>
        /// Zonefare库只读连接
        /// </summary>
        public static string IFltZonefareDB_SELECT
        {
            get
            {
                if (string.IsNullOrEmpty(m_IFltZonefareDB_SELECT))
                {
                    m_IFltZonefareDB_SELECT = JinRiEncryptTool.Decrypt(ConfigurationManager.ConnectionStrings["IFltZonefareDB_SELECT"].ConnectionString, encryptKey);
                }
                return m_IFltZonefareDB_SELECT;
            }
        }

        private static string m_IFltZonefareDB_INSERT;

        /// <summary>
        /// Zonefare库写连接
        /// </summary>
        public static string IFltZonefareDB_INSERT
        {
            get
            {
                if (string.IsNullOrEmpty(m_IFltZonefareDB_INSERT))
                {
                    m_IFltZonefareDB_INSERT = JinRiEncryptTool.Decrypt(ConfigurationManager.ConnectionStrings["IFltZonefareDB_INSERT"].ConnectionString, encryptKey);
                }
                return m_IFltZonefareDB_INSERT;
            }
        }
        #endregion

        #endregion
    }
}
