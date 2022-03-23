using ServiceStack.Mvc;
using System.Web.Mvc;

namespace MvcWithServiceStack.Controllers
{
    public class HomeController : ServiceStackController
    {
        public ActionResult Index()
        {
            return View("index", null, AppSettings.Get<string>("custom"));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}