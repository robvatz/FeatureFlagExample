using System;
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
            SetViewFeatures();
            ViewBag.Message = "";
            return View();
        }

        public ViewResult About()
        {
            SetViewFeatures();
            ViewBag.Message = "";
            return View();
        }

        public ViewResult Contact()
        {
            SetViewFeatures();
            ViewBag.Message = "";
            return View();
        }

        public ViewResult NewPage()
        {
            SetViewFeatures();
            ViewBag.Message = "";
            return View();
        }

        public ActionResult ThrowAnException()
        {
            SetViewFeatures();
            // TODO: add graceful recovery from exceptions to project
            throw new NotImplementedException("Any exception will do here");
        }

        private void SetViewFeatures()
        {
            _ifs.CheckFeatureFlags();
            ViewBag.ExtraMenuFeature = _ifs.ShowNewMenu;
        }
    }
}
