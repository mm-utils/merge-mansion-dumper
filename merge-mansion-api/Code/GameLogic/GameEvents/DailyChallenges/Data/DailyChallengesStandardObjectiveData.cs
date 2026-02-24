using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Requirements;
using System.Collections.Generic;
using System;
using GameLogic.StatsTracking;
using Game.Cloud.Config;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesStandardObjectiveData : IGameConfigData<DailyChallengesStandardObjectiveId>, IGameConfigData, IHasGameConfigKey<DailyChallengesStandardObjectiveId>, IHasRequirements
    {
        [MetaMember(7, (MetaMemberFlags)0)]
        private List<PlayerRequirement> _requirements;
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesStandardObjectiveId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int ObjectiveRequirement { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public StatsObjectiveType ObjectiveType { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int OrderPriority { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<string> ObjectiveParameter { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public DailyChallengesStandardObjectiveRewardPoolData RewardsPoolData { get; set; }
        public IEnumerable<PlayerRequirement> Requirements { get; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<ConfigId<DailyChallengesStandardObjectiveId, DailyChallengesStandardObjectiveData>> FallbackObjectiveIdReferencesList { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public string LocId { get; set; }
    }
}