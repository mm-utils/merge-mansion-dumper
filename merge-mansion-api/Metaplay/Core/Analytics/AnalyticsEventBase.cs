using Metaplay.Core.Model;
using Metaplay.Core.Json;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace Metaplay.Core.Analytics
{
    [MetaSerializable]
    public abstract class AnalyticsEventBase : IMetaIntegration<AnalyticsEventBase>, IMetaIntegration
    {
        protected AnalyticsEventBase()
        {
        }

        [IncludeOnlyInJsonSerializationMode((JsonSerializationMode)3)]
        public IEnumerable<string> Keywords { get; }

        [JsonIgnore]
        public virtual IEnumerable<string> KeywordsForEventInstance { get; }
    }
}