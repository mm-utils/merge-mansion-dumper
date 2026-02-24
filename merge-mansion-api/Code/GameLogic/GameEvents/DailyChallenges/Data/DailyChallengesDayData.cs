using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;
using Game.Cloud.Config;
using GameLogic.Player.Rewards;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesDayData : IGameConfigData<DailyChallengesDayId>, IGameConfigData, IHasGameConfigKey<DailyChallengesDayId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesDayId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<int> MinObjectivesPerGroup { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<int> SpecialObjectiveGroups { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<ConfigId<DailyChallengesStandardObjectiveId, DailyChallengesStandardObjectiveData>> StandardObjectives { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private List<PlayerReward> Rewards { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private List<PlayerSegmentId> RewardSegment { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int TargetMilestoneIndex { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public int RequiredCompletedObjectivesForDayReward { get; set; }
    }
}