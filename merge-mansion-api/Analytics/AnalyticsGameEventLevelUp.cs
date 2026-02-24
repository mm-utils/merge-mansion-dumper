using Metaplay.Core.Analytics;
using Newtonsoft.Json;
using Metaplay.Core.Model;
using System.ComponentModel;
using System;
using Code.GameLogic.GameEvents;

namespace Analytics
{
    [AnalyticsEvent(125, "Event level was reached and claimed", 1, null, false, true, false)]
    public class AnalyticsGameEventLevelUp : AnalyticsServersideEventBase
    {
        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("ID of the event")]
        public string EventId;
        [JsonProperty("claimed_level")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Claimed level")]
        public int ClaimedLevel;
        [JsonProperty("auto_claim")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Was the level claimed automatically?")]
        public bool AutoClaim;
        [JsonProperty("event_level_id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Event level id")]
        public EventLevelId EventLevelId;
        public override AnalyticsEventType EventType { get; }
        public override string EventDescription { get; }

        public AnalyticsGameEventLevelUp()
        {
        }

        [JsonProperty("resource_item_used", NullValueHandling = (NullValueHandling)1)]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("The amount of ResourceItems used until now in the whole event (SideBoardEvent only)")]
        public int? ResourceItemUsed;
        [JsonProperty("level_group")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Act number of the event (The Great Escape only)")]
        public int LevelGroup;
        [JsonProperty("placement")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Placement where the level was reached")]
        public string Placement;
        [JsonProperty("unlock_order")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Unlock order of difficulty")]
        public int UnlockOrder;
    }
}