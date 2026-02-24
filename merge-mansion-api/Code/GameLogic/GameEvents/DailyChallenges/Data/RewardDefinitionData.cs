using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class RewardDefinitionData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string RewardId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private string RewardType { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private string RewardAux0 { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private string RewardAux1 { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private List<int> RewardAmounts { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public Dictionary<PlayerSegmentId, int> WeightPerSegment { get; set; }
    }
}