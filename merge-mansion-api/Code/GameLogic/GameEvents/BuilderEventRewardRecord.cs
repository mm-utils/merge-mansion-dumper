using Metaplay.Core.Model;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventRewardRecord
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int RewardAmount { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string RewardId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string RewardType { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string RewardAux0 { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string RewardAux1 { get; set; }
    }
}