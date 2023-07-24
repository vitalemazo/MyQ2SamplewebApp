using System.Web.Mvc;

namespace DotNetFrameworkApp.Worker.WebApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
    }
}
