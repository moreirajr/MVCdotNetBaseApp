using System.Web.Mvc;

namespace MVCdotNetBaseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }     
    }
}