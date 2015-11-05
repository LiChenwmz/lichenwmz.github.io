using System.Web.Mvc;

namespace WebCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Web()
        {
            return View();
        }

        public ActionResult CSharp()
        {
            return View();
        }
        public ActionResult Mvc()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }

        public ActionResult Tool()
        {
            return View("ProjectTool");
        }

        public ActionResult Other()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Teacher_J()
        {
            return View();
        }
    }
}