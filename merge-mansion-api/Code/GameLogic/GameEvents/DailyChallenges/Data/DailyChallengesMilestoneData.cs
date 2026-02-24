using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesMilestoneData : IGameConfigData<DailyChallengesMilestoneId>, IGameConfigData, IHasGameConfigKey<DailyChallengesMilestoneId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesMilestoneId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int RequiredPoints { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<PlayerSegmentId> RewardSegment { get; set; }
    }
}