using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventCollectionInfo : IGameConfigData<BuilderEventCollectionId>, IGameConfigData, IHasGameConfigKey<BuilderEventCollectionId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventCollectionId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<BuilderEventBuildId> Builds { get; set; }
    }
}