using Metaplay.Core.Model;
using Metaplay.Core.Analytics;
using System;
using Newtonsoft.Json;
using System.ComponentModel;
using Code.GameLogic.GameEvents.DailyChallenges;
using GameLogic.StatsTracking;

namespace Analytics
{
    [MetaSerializable]
    [AnalyticsEvent(226, "Daily Challenges objective status changed", 1, null, true, true, false)]
    public class AnalyticsDailyChallengesDailyObjectiveStatus : AnalyticsServersideEventBase
    {
        public override string EventDescription { get; }
        public override AnalyticsEventType EventType { get; }

        [JsonProperty("event_id")]
        [MetaMember(1, (MetaMemberFlags)0)]
        [Description("Event ID")]
        public string EventId { get; set; }

        [JsonProperty("week_id")]
        [MetaMember(2, (MetaMemberFlags)0)]
        [Description("Week ID")]
        public string WeekId { get; set; }

        [JsonProperty("week_difficulty")]
        [MetaMember(3, (MetaMemberFlags)0)]
        [Description("Week Difficulty")]
        public string WeekDifficulty { get; set; }

        [JsonProperty("day_id")]
        [MetaMember(4, (MetaMemberFlags)0)]
        [Description("Day ID")]
        public string DayId { get; set; }

        [JsonProperty("objective_id")]
        [MetaMember(5, (MetaMemberFlags)0)]
        [Description("Objective ID")]
        public string ObjectiveId { get; set; }

        [JsonProperty("objective_category")]
        [MetaMember(6, (MetaMemberFlags)0)]
        [Description("Objective Category (Standard/Special)")]
        public DailyChallengesObjectiveCategory ObjectiveCategory { get; set; }

        [JsonProperty("status")]
        [MetaMember(7, (MetaMemberFlags)0)]
        [Description("Status of the objective, Unlocked/Completed")]
        public AnalyticsDailyChallengesDailyObjectiveStatus.ObjectiveStatus Status { get; set; }

        [JsonProperty("objective_type")]
        [MetaMember(8, (MetaMemberFlags)0)]
        [Description("Objective Type")]
        public StatsObjectiveType ObjectiveType { get; set; }

        [JsonProperty("completed_objective_amount")]
        [MetaMember(9, (MetaMemberFlags)0)]
        [Description("Current amount of completed daily objectives")]
        public int CompletedObjectivesAmount { get; set; }

        [JsonProperty("required_objective_amount")]
        [MetaMember(10, (MetaMemberFlags)0)]
        [Description("Required amount of completed objectives for daily completion")]
        public int RequiredObjectiveAmount { get; set; }

        [JsonProperty("token_saldo")]
        [MetaMember(11, (MetaMemberFlags)0)]
        [Description("DailyChallenges CSE Tokens saldo")]
        public int TokenSaldo { get; set; }

        [JsonProperty("time_left_seconds")]
        [MetaMember(12, (MetaMemberFlags)0)]
        [Description("Time left until daily objectives refresh")]
        public int TimeLeftSeconds { get; set; }

        [JsonProperty("objective_parameter")]
        [MetaMember(13, (MetaMemberFlags)0)]
        [Description("Custom parameter related to the objective type")]
        public string ObjectiveParameter { get; set; }

        [JsonProperty("objective_requirement")]
        [MetaMember(14, (MetaMemberFlags)0)]
        [Description("Requirement value for the objective")]
        public int ObjectiveRequirement { get; set; }

        [MetaSerializable]
        public enum ObjectiveStatus
        {
            Unlocked = 0,
            Completed = 1
        }
    }
}