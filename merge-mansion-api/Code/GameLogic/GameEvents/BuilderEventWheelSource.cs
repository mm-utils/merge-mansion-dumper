using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventWheelSource : IConfigItemSource<BuilderEventWheelInfo, BuilderEventWheelId>, IGameConfigSourceItem<BuilderEventWheelId, BuilderEventWheelInfo>, IHasGameConfigKey<BuilderEventWheelId>
    {
        public BuilderEventWheelId ConfigKey { get; set; }
        public List<BuilderEventWheelPartId> WheelPartIds { get; set; }
        public List<int> Multipliers { get; set; }
        public List<int> MinTokensToShowMultiplier { get; set; }
        public int RollTokenCost { get; set; }
    }
}