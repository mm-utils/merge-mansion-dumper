using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventCollectionSource : IConfigItemSource<BuilderEventCollectionInfo, BuilderEventCollectionId>, IGameConfigSourceItem<BuilderEventCollectionId, BuilderEventCollectionInfo>, IHasGameConfigKey<BuilderEventCollectionId>
    {
        public BuilderEventCollectionId ConfigKey { get; set; }
        public List<BuilderEventBuildId> Builds { get; set; }
    }
}