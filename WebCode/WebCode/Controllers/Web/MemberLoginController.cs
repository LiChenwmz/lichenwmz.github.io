using System;
using System.Linq;
using System.Web.Mvc;
using WebCode.Models;
using WebCodeTools.Enums;

namespace WebCode.Controllers
{
    public class MemberLoginController : Controller
    {
        ///会员登录
        public ActionResult MemberLogin(string userName,string pwd)
        {
            using (var db=new DbEntities())
            {
                var rel = db.Members.FirstOrDefault(m => m.UserName == userName && m.Pwd == pwd);
                if (rel!=null)
                {
                    //TODO  存到Cookie里面,后面通过方法去调用

                }
                //登录成功之后跳转到首页,在首页会显示登录信息
                return RedirectToAction("Index", "Main");
            }
        }

        ///会员注册
        public ActionResult MemberRead(string userName, string pwd)
        {
            try
            {
                using (var db = new DbEntities())
                {
                    var member = new Member()
                    {
                        UserName = userName,
                        Pwd = pwd
                    };
                    db.Members.Add(member);
                    db.SaveChanges();
                    //TODO  注册成功自动登录,存到Cookie里面,后面通过方法去调用
                    return RedirectToAction("Index", "Main");
                }
            }
            catch (Exception)
            {
                return Json(false);
            }
        }
        ///修改用户密码
        public ActionResult MemberUpdateByPwd(string pwd)
        {
            using (var db = new DbEntities())
            {
                //BUG  这里需要读取Id
                var userId = 1;
                var me = db.Members.FirstOrDefault(m => m.Id == userId);
                if (me == null)
                    return Json(false);
                me.Pwd = pwd;
                var log = new MemberLog()
                {
                    MemberId = me.Id,
                    ModifyContent=MemberModifyEnum.ChangePwd,
                    ModifyTime=DateTime.Now
                };
                db.MemberLogs.Add(log);
                db.SaveChanges();
                return Json(true);
            }
        }
    }
}