using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventTimersSource : IConfigItemSource<BuilderEventTimerInfo, BuilderEventTimerId>, IGameConfigSourceItem<BuilderEventTimerId, BuilderEventTimerInfo>, IHasGameConfigKey<BuilderEventTimerId>
    {
        public BuilderEventTimerId ConfigKey { get; set; }
        public List<BuilderEventTimedRewardId> TimedRewardIds { get; set; }
    }
}