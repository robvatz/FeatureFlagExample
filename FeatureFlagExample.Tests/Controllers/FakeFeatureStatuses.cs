using FeatureFlagExample.Controllers;

namespace FeatureFlagExample.Tests.Controllers
{
    public class FakeFeatureStatuses : IFeatureStatuses
    {
        public bool ShowNewMenu { get; set; }

        public void CheckFeatureFlags()
        {
        }
    }
}
