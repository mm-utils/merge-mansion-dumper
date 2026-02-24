using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventTimerInfo : IGameConfigData<BuilderEventTimerId>, IGameConfigData, IHasGameConfigKey<BuilderEventTimerId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventTimerId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<BuilderEventTimedRewardId> TimedRewardIds { get; set; }
    }
}