using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Requirements;
using System.Collections.Generic;
using System;
using GameLogic.StatsTracking;
using Metaplay.Core.Player;
using Game.Cloud.Config;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesSpecialObjectiveData : IGameConfigData<DailyChallengesSpecialObjectiveId>, IGameConfigData, IHasGameConfigKey<DailyChallengesSpecialObjectiveId>, IHasRequirements
    {
        [MetaMember(8, (MetaMemberFlags)0)]
        private List<PlayerRequirement> _requirements;
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesSpecialObjectiveId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ObjectiveGroup { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<int> ObjectiveRequirement { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public StatsObjectiveType ObjectiveType { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<string> ObjectiveParameter { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public Dictionary<PlayerSegmentId, int> GroupWeightBySegment { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public DailyChallengesSpecialObjectiveRewardPoolData RewardsPoolData { get; set; }
        public IEnumerable<PlayerRequirement> Requirements { get; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<ConfigId<DailyChallengesSpecialObjectiveId, DailyChallengesSpecialObjectiveData>> FallbackObjectiveIdReferencesList { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public string LocId { get; set; }
    }
}