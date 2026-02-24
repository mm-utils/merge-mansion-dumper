using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventBuildStateData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventBuildId BuildId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public BuilderEventBuildState State { get; set; }
    }
}