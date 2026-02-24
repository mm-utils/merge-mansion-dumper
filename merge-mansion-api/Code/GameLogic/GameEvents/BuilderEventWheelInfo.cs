using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventWheelInfo : IGameConfigData<BuilderEventWheelId>, IGameConfigData, IHasGameConfigKey<BuilderEventWheelId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventWheelId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<BuilderEventWheelPartId> WheelPartIds { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int RollTokenCost { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<int> Multipliers { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<int> MinTokensToShowMultiplier { get; set; }
    }
}