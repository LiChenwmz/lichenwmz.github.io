using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using WebCodeTools.Enums;

namespace WebCode.Models
{
    //会员日志表
    public class MemberLog
    {
        public int Id { get; set; }
        [DisplayName("成员Id")]
        public int MemberId { get; set; }
        [DisplayName("修改内容")]
        public MemberModifyEnum ModifyContent { get; set; }
        [DisplayName("修改时间")]
        public DateTime ModifyTime { get; set; }
    }
}
