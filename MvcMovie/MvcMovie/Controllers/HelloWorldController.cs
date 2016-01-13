
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
 
        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int ID = 1)
        {
            ViewBag.Message = name;
            ViewBag.Id = ID;
            return View();
        }
    }
}