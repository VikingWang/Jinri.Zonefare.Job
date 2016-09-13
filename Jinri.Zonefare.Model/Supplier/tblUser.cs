using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jinri.Zonefare.Model.Supplier
{
    public class tblUser
    {
        /// <summary>
        /// 
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? ProviderID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? SalesmanID { get; set; }

        /// <summary>
        /// 部门描述(业务部1,客户服务部 2,技术部4;如果同时属于几个部门则相加)
        /// </summary>
        public int? Dept { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PassWord2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? DotNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? DotAdmin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OpenPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ZFBPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? ZFBsxf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CFTPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CFTsxf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ZFBuser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ZFBname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? ZFBgain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? ZFBclient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CFTuser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CFTname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CFTgain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? CFTclient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string KouWay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string KouFit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? DianQian { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Admin { get; set; }

        /// <summary>
        /// 添加平台政策权限
        /// </summary>
        public int? RateLock { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LinkMan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MAC { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? IsNet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LoginTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? LeaveTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? StickTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PNRtoOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PolicyQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? FlightQueryN { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? FlightQueryI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PrintOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? OrderTicket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Pay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SetSMS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Fax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Msnqq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MsnAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Info { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Regdata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AliPayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CopartnerID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CFTkey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Ver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Lock { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PrintNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? PrintLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? BeenTradedNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? NotTradedNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? RefundNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? AllNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? AgentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OfficeNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutTicketManTel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutTicketManTel2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutTicketManqq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutTicketManMsn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackTicketManTel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackTicketManqq { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BackTicketManMsn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WorkTimeBegin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string WorkTimeEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CaiFuTongName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SendNumStr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Efficiency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? EfficiencyDate { get; set; }

        /// <summary>
        /// 退票效率
        /// </summary>
        public int? Cancel_Efficiency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Cancel_EfficiencyDate { get; set; }

        /// <summary>
        /// 0表示有政策开关权限；1表示没有
        /// </summary>
        public int? RatePowerLock { get; set; }

        /// <summary>
        /// 绑定客服
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// 所属供票商
        /// </summary>
        public string CompanyID { get; set; }

        /// <summary>
        /// 多种权限
        /// </summary>
        public string MorePower { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string OutCsUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CsUserId { get; set; }

        /// <summary>
        /// 登录状态[0离线、1在线]
        /// </summary>
        public int? LoginState { get; set; }

        /// <summary>
        /// 最后活动时间
        /// </summary>
        public DateTime? LastActiveDatetime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid msrepl_tran_version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string KQPay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? KQsxf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string KQuser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string KQname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? KQgain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double? KQclient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsUsedKqBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastActiveIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? HotelSalesmanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SerialNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? HasLocalPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? IsFreeze { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? AlwaysClose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AboutJinRi { get; set; }

        /// <summary>
        /// 所属用户组代号
        /// </summary>
        public string GroupCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? UserGroupCode { get; set; }

        /// <summary>
        /// 供票商是否与汇付通签约
        /// </summary>
        public int? ChinaPnrSign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string IsUsedChinaPnrBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CsId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Supplyid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 是否是新平台用户
        /// </summary>
        public bool? IsNew { get; set; }

        /// <summary>
        /// Vip等级
        /// </summary>
        public int? VipLevel { get; set; }

        /// <summary>
        /// Vip分等级关闭之前的Vip状态
        /// </summary>
        public int? DotAdminOld { get; set; }

        /// <summary>
        /// Vip返点城市
        /// </summary>
        public string VipCity { get; set; }

        /// <summary>
        /// 0：VipCity字段存放的是Vip排除城市；1：VipCity字段存放的是Vip包含城市
        /// </summary>
        public int? IsVipCity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string JTBAccount { get; set; }
    }
}
