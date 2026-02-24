using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using System.ComponentModel;
using Newtonsoft.Json;
using Merge;
using System;
using Metaplay.Core;
using System.Collections.Generic;
using GameLogic.Player;

namespace Analytics
{
    [AnalyticsEvent(122, "Player snapshot", 1, null, false, true, false)]
    [MetaBlockedMembers(new int[] { 2, 3, 4, 5, 7, 9 })]
    public class AnalyticsEventPlayerSnapshot : AnalyticsServersideEventBase
    {
        public sealed override AnalyticsEventType EventType { get; }

        [JsonProperty("gathered_from")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Point at which snapshot was gathered (0 - session start, 1 - session end, 2 - mid-session)")]
        public AnalyticsSnapshotType SnapshotType { get; set; }

        [JsonProperty("current_event")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Player's current story event (if present) represented as event merge board ID")]
        public MergeBoardId CurrentStoryEventBoardId { get; set; }

        [JsonProperty("saldo_diamond_purchased")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Player's hard (purchased with real money) gems balance")]
        public long HardDiamondsSaldo { get; set; }

        [JsonProperty("saldo_coins_purchased")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Player's hard (purchased with real money) coins balance")]
        public long HardCoinsSaldo { get; set; }

        [JsonProperty("session_count_lt")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("How many sessions player had over lifetime")]
        public long SessionCount { get; set; }

        [JsonProperty("lt_in_app_purchase_count")]
        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("How many IAPs player purchased over lifetime")]
        public int TotalIAPBought { get; set; }

        [JsonProperty("first_purchase_date")]
        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Date of the first purchase")]
        public MetaTime FirstPurchase { get; set; }

        [JsonProperty("user_first_touch_timestamp")]
        [MetaMember(14, (MetaMemberFlags)0)]
        [Description("Date of the first session")]
        public MetaTime FirstSession { get; set; }

        [JsonProperty("engagement_time_min")]
        [MetaMember(15, (MetaMemberFlags)0)]
        [Description("Engagement time in minutes")]
        public double EngagementTimeInMin { get; set; }

        [JsonProperty("merge_goals_completed")]
        [MetaMember(16, (MetaMemberFlags)0)]
        [Description("How many merge goals player completed")]
        public int MergeGoalsCompleted { get; set; }

        [JsonProperty("merge_goals_open")]
        [MetaMember(17, (MetaMemberFlags)0)]
        [Description("How many merge goals player opened")]
        public int MergeGoalsOpen { get; set; }

        [JsonProperty("game_events_interacted_and_active")]
        [MetaMember(18, (MetaMemberFlags)0)]
        [Description("Game Events that have been interacted with (task completed and active)")]
        public string ActiveAndInteractedWithGameEvents { get; set; }

        [JsonProperty("music_is_muted")]
        [MetaMember(19, (MetaMemberFlags)0)]
        [Description("Player music state, is the music muted or note")]
        public bool MusicIsMuted { get; set; }

        [JsonProperty("sfx_is_muted")]
        [MetaMember(20, (MetaMemberFlags)0)]
        [Description("Player sfx state, is the sfx muted or note")]
        public bool SfxIsMuted { get; set; }

        [JsonProperty("garage_inventory_slots")]
        [MetaMember(21, (MetaMemberFlags)0)]
        [Description("Total amount of Garage inventory slots")]
        public int GarageInventorySlots { get; set; }

        [JsonProperty("garage_free_inventory_slots")]
        [MetaMember(22, (MetaMemberFlags)0)]
        [Description("Free amount of Garage inventory slots")]
        public int GarageFreeInventorySlots { get; set; }

        [JsonProperty("empty_board_slots")]
        [MetaMember(23, (MetaMemberFlags)0)]
        [Description("Empty board slot counts")]
        [MetaAllowNondeterministicCollection]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<string, int> EmptyBoardSlots { get; set; }

        [JsonProperty("hidden_board_items")]
        [MetaMember(24, (MetaMemberFlags)0)]
        [Description("Empty board slot counts")]
        [MetaAllowNondeterministicCollection]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<MergeBoardId, int> HiddenBoardItems { get; set; }

        [JsonProperty("lt_in_app_purchase_revenue")]
        [MetaMember(25, (MetaMemberFlags)0)]
        [Description("Empty board slot counts")]
        public float TotalIAPRevenue { get; set; }

        [JsonProperty("merge_counts")]
        [MetaMember(26, (MetaMemberFlags)0)]
        [Description("Total merges since 2204 update")]
        [BigQueryAnalyticsFormat((BigQueryAnalyticsFormatMode)0)]
        public Dictionary<MergeBoardId, int> MergeCounts { get; set; }

        [JsonProperty("location")]
        [MetaMember(27, (MetaMemberFlags)0)]
        [Description("String describing approximate location")]
        public string Location { get; set; }

        [JsonProperty("device")]
        [MetaMember(28, (MetaMemberFlags)0)]
        [Description("String identifying the device")]
        public string Device { get; set; }

        [JsonProperty("platform")]
        [MetaMember(29, (MetaMemberFlags)0)]
        [Description("String identifying the device")]
        public ClientPlatform Platform { get; set; }

        [JsonProperty("merge_goals_count_exclude_unlock")]
        [MetaMember(30, (MetaMemberFlags)0)]
        [Description("How many merge goals player has excluding area unlocks")]
        public int MergeGoalsOpenExcludeUnlock { get; set; }
        public override string EventDescription { get; }

        public AnalyticsEventPlayerSnapshot()
        {
        }

        public AnalyticsEventPlayerSnapshot(PlayerModel player, AnalyticsSnapshotType snapshotType)
        {
        }

        [JsonProperty("merge_hints_are_on")]
        [MetaMember(31, (MetaMemberFlags)0)]
        [Description("Are merge hints enabled or not")]
        public bool MergeHintsAreOn { get; set; }

        [JsonProperty("producer_inventory_slots")]
        [MetaMember(32, (MetaMemberFlags)0)]
        [Description("Total amount of Producer inventory slots")]
        public int ProducerInventorySlots { get; set; }

        [JsonProperty("free_producer_inventory_slots")]
        [MetaMember(33, (MetaMemberFlags)0)]
        [Description("Free amount of Producer inventory slots")]
        public int FreeProducerInventorySlots { get; set; }

        [JsonProperty("haptics_is_on")]
        [MetaMember(34, (MetaMemberFlags)0)]
        [Description("Player haptics state, are the haptics on or off")]
        public bool HapticsIsOn { get; set; }

        [JsonProperty("notifications_are_on")]
        [MetaMember(35, (MetaMemberFlags)0)]
        [Description("whether notifications are enabled or not")]
        public bool NotificationsAreOn { get; set; }
    }
}