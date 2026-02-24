using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Rewards;
using System;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventTimedRewardInfo : IGameConfigData<BuilderEventTimedRewardId>, IGameConfigData, IHasGameConfigKey<BuilderEventTimedRewardId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventTimedRewardId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public PlayerReward Reward { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public long Cooldown { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public long Delay { get; set; }
        public MetaDuration CooldownTime { get; }
        public MetaDuration DelayTime { get; }
    }
}