using Metaplay.Core.Model;
using System;
using Code.GameLogic.GameEvents.DailyChallenges.Data;
using GameLogic.Player.Rewards;
using System.Collections.Generic;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents.DailyChallenges
{
    [MetaSerializableDerived(5)]
    public class DailyChallengesMinigameModel : IDailyChallengesMinigameModel, ICoreSupportEventMinigameModel
    {
        [MetaMember(14, (MetaMemberFlags)0)]
        private bool _subscribed;

        private CoreSupportEventMinigameId _minigameId;

        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesMinigameId MinigameId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public DailyChallengesWeekId EventWeekId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public DailyChallengesDayId CurrentDayId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public float DailyProgress { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public float WeeklyProgress { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private PlayerReward CurrentDailyReward { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public bool DailyRewardClaimed { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public bool TodayObjectiveSeen { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public CoreSupportEventId EventId { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public List<DailyChallengesObjectiveModel> CurrentStandardTasks { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public List<DailyChallengesObjectiveModel> CurrentSpecialTasks { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public List<DailyChallengesMilestoneModel> Milestones { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public MetaTime EndOfCurrentDayTimestamp { get; set; }
        public int CompletedStandardObjectivesCount { get; }

        CoreSupportEventMinigameId ICoreSupportEventMinigameModel.MinigameId => _minigameId;
    }
}