using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Model.Supplier
{
    public class tblInterUser
    {
        /// <summary>
        /// 用户工号
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// 支付宝帐号
        /// </summary>
        public string ZFBUser { get; set; }

        /// <summary>
        /// 默认支付方式
        /// </summary>
        public string OpenPay { get; set; }

        /// <summary>
        /// 邮件地址
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 国际负责人
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 国际传真
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// 国际公司地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// QQ
        /// </summary>
        public string Msnqq { get; set; }

        /// <summary>
        /// MSN账户
        /// </summary>
        public string MsnAccount { get; set; }

        /// <summary>
        /// 业务员ID
        /// </summary>
        public string SalesmanID { get; set; }

        /// <summary>
        /// 用户供应商
        /// </summary>
        public string ProviderID { get; set; }

        /// <summary>
        /// 是否开通
        /// </summary>
        public bool? Lock { get; set; }

        /// <summary>
        /// 支付宝账号
        /// </summary>
        public string ZFBAccount { get; set; }

        /// <summary>
        /// 快钱账号
        /// </summary>
        public string KQAccount { get; set; }

        /// <summary>
        /// 财付通账号
        /// </summary>
        public string CFTAccount { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        public string ComeFrom { get; set; }

        /// <summary>
        /// 出票人电话
        /// </summary>
        public string OutTicketTel { get; set; }

        /// <summary>
        /// 出票人QQ
        /// </summary>
        public string OutTicketQQ { get; set; }

        /// <summary>
        /// 出票人MSN
        /// </summary>
        public string OutTicketMSN { get; set; }

        /// <summary>
        /// 退票人电话
        /// </summary>
        public string BackTicketTel { get; set; }

        /// <summary>
        /// 退票人QQ
        /// </summary>
        public string BackTicketQQ { get; set; }

        /// <summary>
        /// 退票人MSN
        /// </summary>
        public string BackTicketMSN { get; set; }

        /// <summary>
        /// 工作时间
        /// </summary>
        public string WorkTime { get; set; }

        /// <summary>
        /// 绑定时间
        /// </summary>
        public string BindTime { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 业务员名
        /// </summary>
        public string SalesmanName { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? isupd { get; set; }

        /// <summary>
        /// 用户等级
        /// </summary>
        public string userlevel { get; set; }

        /// <summary>
        /// 周六工作时间
        /// </summary>
        public string WorkTimetxtend { get; set; }

        /// <summary>
        /// 周日工作时间
        /// </summary>
        public string worktimetxtens { get; set; }

        /// <summary>
        /// 用户留言回复
        /// </summary>
        public string userevaluationpri { get; set; }

        /// <summary>
        /// 用户留言
        /// </summary>
        public string userevaluation { get; set; }

        /// <summary>
        /// 汇付帐号
        /// </summary>
        public string HFTAccount { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        public string userrole { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public string regtime { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public string CompanyID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? AuditingTimeOut { get; set; }

        /// <summary>
        /// 最晚退款时间【天】客规自愿退票
        /// </summary>
        public int? RefundTimeOut { get; set; }

        /// <summary>
        /// 最晚退款时间【天】非自愿或特殊退票
        /// </summary>
        public int? CancelTimeOut { get; set; }

        /// <summary>
        /// 最晚退款时间【天】航班延误申请全退
        /// </summary>
        public int? DelayTimeOut { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 加钱
        /// </summary>
        public int? addmoney { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int? is_use { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City_name { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        public string UserCardID { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime? RegisterTime { get; set; }

        /// <summary>
        /// 供应商等级。默认1。 0为初级的供应商
        /// </summary>
        public int? ProviderLevel { get; set; }

        /// <summary>
        /// 政策出票时间类型  1 政策时间为主 2 用户时间为主
        /// </summary>
        public int? WtimeMatType { get; set; }

        /// <summary>
        /// 修改密码时间
        /// </summary>
        public DateTime? UpdatePassWordTime { get; set; }

        /// <summary>
        /// 是否开启此供应商的报表导出接口功能
        /// </summary>
        public int? IsOutExcel { get; set; }

        /// <summary>
        /// 今通宝帐号
        /// </summary>
        public string JTBAccount { get; set; }

        /// <summary>
        /// 紧急联系人
        /// </summary>
        public string UrgentUserName { get; set; }

        /// <summary>
        /// 紧急联系人手机
        /// </summary>
        public string UrgentMobile { get; set; }

        /// <summary>
        /// 10 企业用户 20个人用户
        /// </summary>
        public int RegisterType { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// OFFICE号
        /// </summary>
        public string OfficeNo { get; set; }

        /// <summary>
        /// 联系方式缺失标记
        /// </summary>
        public int? MisSate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? MissDatetime { get; set; }

        /// <summary>
        /// 状态为1时 是问题供应商的状态 0正常
        /// </summary>
        public int? ProblemState { get; set; }

        /// <summary>
        /// 设置为问题供应商的时间
        /// </summary>
        public DateTime? ProblemDatetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UserChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? BindFlag { get; set; }

        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

        /// <summary>
        /// 密码错误次数
        /// </summary>
        public int PwdFailCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AccountType { get; set; }
    }
}
