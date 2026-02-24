using Metaplay.Core.Model;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using Code.GameLogic.StatsTracking;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges
{
    [MetaSerializable]
    public class DailyChallengesObjectiveModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private List<PlayerReward> Rewards { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public IStatsObjective StatsObjective { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public DailyChallengesObjectiveCategory Category { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int OrderPriority { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public bool RewardsOverridenByCatchupLogic { get; set; }
        public string StatsObjectiveId { get; }
    }
}