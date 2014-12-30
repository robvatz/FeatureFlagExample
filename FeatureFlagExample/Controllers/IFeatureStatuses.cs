namespace FeatureFlagExample.Controllers
{
    /// <summary>
    /// Provides info on features in effect.
    /// </summary>
    public interface IFeatureStatuses
    {
        /// <summary>
        /// Set ViewBag values to indicate which features are available.
        /// </summary>
        void CheckFeatureFlags(dynamic viewBag);
    }
}
