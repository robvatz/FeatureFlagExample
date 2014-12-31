using System.Web.Configuration;

namespace FeatureFlagExample.Controllers
{
    public class FeatureStatuses : IFeatureStatuses
    {
        public bool ShowNewMenu { get; private set; }

        /// <summary>
        /// Set ViewBag values to indicate which features are available.
        /// </summary>
        public void CheckFeatureFlags()
        {
            string setting = WebConfigurationManager.AppSettings["new-menu-feature"];

            ShowNewMenu = setting != null && (setting == "true" || setting == "yes");
        }
    }
}
