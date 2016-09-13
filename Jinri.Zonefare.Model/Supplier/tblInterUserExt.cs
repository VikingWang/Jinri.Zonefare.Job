using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Model.Supplier
{
    public class tblInterUserExt
    {
        /// <summary>
        /// 用户名
        /// 唯一约束
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 性别
        /// 个人专用
        /// </summary>
        public byte? Sex { get; set; }

        /// <summary>
        /// 证件类型
        /// 个人专用
        /// </summary>
        public byte? CredType { get; set; }

        /// <summary>
        /// 公司执照
        /// 个人专用
        /// </summary>
        public string PersonalBizLicence { get; set; }

        /// <summary>
        /// 总公司
        /// </summary>
        public string HeadCompany { get; set; }

        /// <summary>
        /// 公司性质
        /// </summary>
        public byte? CompanyType { get; set; }

        /// <summary>
        /// 公司规模
        /// </summary>
        public byte? CompanyScale { get; set; }

        /// <summary>
        /// 公司网址
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 销售模式
        /// </summary>
        public byte? SaleMode { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        public byte? BizType { get; set; }

        /// <summary>
        /// 航空销售代理业务经营批准证书号
        /// </summary>
        public string FlightLicence { get; set; }

        /// <summary>
        /// 国际航协(IATA)认可证书号
        /// </summary>
        public string IATALicence { get; set; }

        /// <summary>
        /// OFFICE号
        /// </summary>
        public string OFFICELicence { get; set; }

        /// <summary>
        /// 手机绑定标志位
        /// </summary>
        public byte? BindMobileFlag { get; set; }

        /// <summary>
        /// 邮箱绑定标志位
        /// </summary>
        public byte? BindEmailFlag { get; set; }

        /// <summary>
        /// 密码安全程度得分
        /// </summary>
        public byte? PwdScore { get; set; }

        /// <summary>
        /// 是否审核中(是则用户自己看到的是临时表中未审核的信息)
        /// </summary>
        public byte? IsAuditing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? is_call { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsQuote { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ImageUrl { get; set; }

        /// <summary>
        /// 分销商航班变动设置，默认0值,0：未开启；1：开启
        /// </summary>
        public int IsAirChangeCall { get; set; }

        /// <summary>
        /// 分销商暂不能变动设置，默认0值,0：未开启；1：开启
        /// </summary>
        public int IsPauseCall { get; set; }

        /// <summary>
        /// 平台管理费更新时间
        /// </summary>
        public DateTime AddMoneyUpTime { get; set; }

        /// <summary>
        /// 平台费更新用户名
        /// </summary>
        public string AddMoneyUpUserName { get; set; }

        /// <summary>
        /// 是否导弹限制，默认0值,0：不能限制；1：限制
        /// </summary>
        public int IsImportOrders { get; set; }

        /// <summary>
        /// 限制导弹日期
        /// </summary>
        public DateTime ImportDate { get; set; }

        /// <summary>
        /// 1：境内；2：境外
        /// </summary>
        public int? ProviderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CallCount { get; set; }

        /// <summary>
        /// 改期对接QQ
        /// </summary>
        public string ChangeQQ { get; set; }

        /// <summary>
        /// 退票对接QQ
        /// </summary>
        public string RefundQQ { get; set; }

        /// <summary>
        /// 用户评级
        /// </summary>
        public string UserGrade { get; set; }

        /// <summary>
        /// 退票QQ群
        /// </summary>
        public string BackQQGroup { get; set; }

        /// <summary>
        /// 改期QQ群
        /// </summary>
        public string ChangeQQGroup { get; set; }
    }
}
