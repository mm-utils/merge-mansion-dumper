using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventWheelPartInfo : IGameConfigData<BuilderEventWheelPartId>, IGameConfigData, IHasGameConfigKey<BuilderEventWheelPartId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventWheelPartId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public BuilderEventRewardRecord RewardRecord { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<int> SegmentWeights { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<PlayerSegmentId> Segments { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int Weight { get; set; }
    }
}