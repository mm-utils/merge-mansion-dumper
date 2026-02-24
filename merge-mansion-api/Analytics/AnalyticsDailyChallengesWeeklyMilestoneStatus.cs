using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using System;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Analytics
{
    [MetaSerializable]
    [AnalyticsEvent(227, "Daily Challenges weekly milestone status changed", 1, null, true, true, false)]
    public class AnalyticsDailyChallengesWeeklyMilestoneStatus : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event ID")]
        public string EventId { get; set; }

        [JsonProperty("current_completion_rate")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Current Completion Rate (0-1)")]
        public float CurrentCompletionRate { get; set; }

        [JsonProperty("week_id")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Week ID")]
        public string WeekId { get; set; }

        [JsonProperty("week_difficulty")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Week Difficulty")]
        public string WeekDifficulty { get; set; }

        [JsonProperty("milestone_id")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Milestone ID")]
        public string MilestoneId { get; set; }

        [JsonProperty("status")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Status of milestone")]
        public string Status { get; set; }

        [JsonProperty("current_milestone")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Current Week Milestone")]
        public int CurrentMilestone { get; set; }

        [JsonProperty("target_milestone")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Target Milestone")]
        public int TargetMilestone { get; set; }

        [JsonProperty("token_saldo")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [Description("DailyChallenges CSE Tokens saldo")]
        public int TokenSaldo { get; set; }

        [JsonProperty("time_left_seconds")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Time left until end of week/event")]
        public int TimeLeftSeconds { get; set; }

        [JsonProperty("day_id")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("Day ID")]
        public string DayId { get; set; }
    }
}