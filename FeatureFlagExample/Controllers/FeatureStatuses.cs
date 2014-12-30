namespace FeatureFlagExample.Controllers
{
    public class FeatureStatuses : IFeatureStatuses
    {
        /// <summary>
        /// Set ViewBag values to indicate which features are available.
        /// </summary>
        public void CheckFeatureFlags(dynamic viewBag)
        {
            viewBag.ExtraMenuFeature = "Y";
        }
    }
}
