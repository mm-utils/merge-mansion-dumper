using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventWheelPartsSource : IConfigItemSource<BuilderEventWheelPartInfo, BuilderEventWheelPartId>, IGameConfigSourceItem<BuilderEventWheelPartId, BuilderEventWheelPartInfo>, IHasGameConfigKey<BuilderEventWheelPartId>
    {
        public BuilderEventWheelPartId ConfigKey { get; set; }
        public int RewardAmount { get; set; }
        public string RewardId { get; set; }
        public string RewardType { get; set; }
        public string RewardAux0 { get; set; }
        public string RewardAux1 { get; set; }
        public List<int> SegmentWeights { get; set; }
        public List<string> UserSegments { get; set; }
        public int Weight { get; set; }
    }
}