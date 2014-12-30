using System.Web.Mvc;

namespace FeatureFlagExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureStatuses _ifs;

        public HomeController() : this(new FeatureStatuses()) {}

        public HomeController(IFeatureStatuses ifs)
        {
            _ifs = ifs;
        }

        public ActionResult Index()
        {
            _ifs.CheckFeatureFlags(ViewBag);
            ViewBag.Message = "";
            return View();
        }

        public ViewResult About()
        {
            _ifs.CheckFeatureFlags(ViewBag);
            ViewBag.Message = "";
            return View();
        }

        public ViewResult Contact()
        {
            _ifs.CheckFeatureFlags(ViewBag);
            ViewBag.Message = "";
            return View();
        }

        public ViewResult NewPage()
        {
            _ifs.CheckFeatureFlags(ViewBag);
            ViewBag.Message = "";
            return View();
        }
    }
}
