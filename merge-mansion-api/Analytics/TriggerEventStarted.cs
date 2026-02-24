using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace Analytics
{
    [AnalyticsEvent(3048, "Event started", 1, null, false, false, true)]
    public class TriggerEventStarted : PlayerTriggerEvent
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("event_id")]
        [Description("Event started")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public string EventId { get; set; }
    }
}