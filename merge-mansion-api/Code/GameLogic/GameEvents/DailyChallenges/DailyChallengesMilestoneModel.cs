using Metaplay.Core.Model;
using GameLogic.Player.Rewards;
using System;
using Code.GameLogic.GameEvents.DailyChallenges.Data;

namespace Code.GameLogic.GameEvents.DailyChallenges
{
    [MetaSerializable]
    public class DailyChallengesMilestoneModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private PlayerReward PlayerReward { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int RequiredPoints { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public DailyChallengesMilestoneId MilestoneId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public bool IsClaimed { get; set; }
    }
}