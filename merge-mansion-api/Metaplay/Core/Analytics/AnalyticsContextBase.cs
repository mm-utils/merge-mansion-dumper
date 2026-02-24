using Metaplay.Core.Model;

namespace Metaplay.Core.Analytics
{
    [MetaSerializable]
    public abstract class AnalyticsContextBase : IMetaIntegration<AnalyticsContextBase>, IMetaIntegration
    {
        protected AnalyticsContextBase()
        {
        }
    }
}