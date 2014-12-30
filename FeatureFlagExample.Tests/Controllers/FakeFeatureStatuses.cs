using FeatureFlagExample.Controllers;

namespace FeatureFlagExample.Tests.Controllers
{
    public class FakeFeatureStatuses : IFeatureStatuses
    {
        public void CheckFeatureFlags(dynamic viewBag)
        {
            viewBag.ExtraMenuFeature = ExtraMenuFeature;
        }

        public string ExtraMenuFeature;
    }
}
