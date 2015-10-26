using System;
using System.ComponentModel;
using WebCodeTools.Enums;

namespace WebCode.Models
{
    public class Member
    {
        public int Id { get; set; }
        [DisplayName("成员帐号")]
        public string UserName { get; set; }
        [DisplayName("成员密码")]
        public string Pwd { get; set; }
        [DisplayName("帐号状态")]
        public MemberStatusEnum Status { get; set; }
        [DisplayName("添加时间")]
        public DateTime AddTime { get; set; }
        [DisplayName("成员昵称")]
        public string Name { get; set; }

        //TODO 成员密码Md5加密方法
        public string PwdMd5(string pwd)
        {
            return pwd;
        }
    }
}
