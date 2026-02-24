using Metaplay.Core.Model;
using GameLogic.Player.Rewards;
using System;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class TimedRewardData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventTimedRewardId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public PlayerReward Reward { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private long CooldownTimeLeft { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private long DelayTimeLeft { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private long CreatedAt { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public TimedRewardState State { get; set; }
        public MetaTime CreatedAtTime { get; }
        public MetaDuration Cooldown { get; }
        public MetaDuration Delay { get; }
    }
}