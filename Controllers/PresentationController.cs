using System.Web.Mvc;

namespace Routing.Abstraction.Controllers
{
    public class PresentationController : Controller
    {
        //
        // GET: /Presentation/

        public ActionResult Index()
        {
            return View();
        }

    }
}
