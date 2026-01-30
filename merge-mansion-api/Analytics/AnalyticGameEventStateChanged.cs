using Metaplay.Core.Analytics;
using Metaplay.Core.Model;
using Newtonsoft.Json;
using System.ComponentModel;
using System;

namespace Analytics
{
    [AnalyticsEvent(135, "Game Event state changed", 1, null, false, true, false)]
    public class AnalyticGameEventStateChanged : AnalyticsServersideEventBase
    {
        public override AnalyticsEventType EventType { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [JsonProperty("event_id")]
        [Description("Id of event in question")]
        public string EventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [JsonProperty("event_state")]
        [Description("New state for the event")]
        public string State { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [JsonProperty("level")]
        [Description("Level associated to the event, if any")]
        public int? Level { get; set; }
        public override string EventDescription { get; }

        public AnalyticGameEventStateChanged()
        {
        }

        public AnalyticGameEventStateChanged(string eventId, string state, int? level)
        {
        }

        [MetaMember(4, (MetaMemberFlags)0)]
        [JsonProperty("segmentation_track_id")]
        [Description("The Track ID for the event")]
        public string SegmentationTrackId { get; set; }
    }
}