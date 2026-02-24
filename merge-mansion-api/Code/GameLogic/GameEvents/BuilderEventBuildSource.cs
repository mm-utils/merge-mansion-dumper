using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventBuildSource : IConfigItemSource<BuilderEventBuildInfo, BuilderEventBuildLevelId>, IGameConfigSourceItem<BuilderEventBuildLevelId, BuilderEventBuildInfo>, IHasGameConfigKey<BuilderEventBuildLevelId>
    {
        public BuilderEventBuildLevelId ConfigKey { get; set; }
        public BuilderEventCollectionId CollectionId { get; set; }
        public int BuildNumber { get; set; }
        public int LevelNumber { get; set; }
        public int RequiredPoints { get; set; }
        public int RewardAmount { get; set; }
        public string RewardType { get; set; }
        public string RewardId { get; set; }
        public string RewardAux0 { get; set; }
        public string RewardAux1 { get; set; }
        public List<string> ModeSelectionIds { get; set; }
    }
}