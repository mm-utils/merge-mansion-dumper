using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Game.Cloud.Config;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesWeekData : IGameConfigData<DailyChallengesWeekId>, IGameConfigData, IHasGameConfigKey<DailyChallengesWeekId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesWeekId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<ConfigId<DailyChallengesDayId, DailyChallengesDayData>> Days { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<ConfigId<DailyChallengesMilestoneId, DailyChallengesMilestoneData>> Milestones { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string WeekDifficulty { get; set; }
    }
}