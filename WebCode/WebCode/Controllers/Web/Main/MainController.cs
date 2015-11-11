using System.Web.Mvc;

namespace WebCode.Controllers.Main
{
    public class MainController : Controller
    {
        
        public ActionResult Index()
        {
            //TODO  这里获得登录人的ID
            return View();
        }

        public ActionResult Main_Project()
        {
            return View();
        }
    }
}