using Metaplay.Core.Model;
using Metaplay.Core.Config;
using GameLogic.Player.Rewards;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventMinigameInfo : IGameConfigData<CoreSupportEventMinigameId>, IGameConfigData, IHasGameConfigKey<CoreSupportEventMinigameId>, IDebugBuilderEventMinigameInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public BuilderEventCollectionId CollectionId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public BuilderEventMode Mode { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public PlayerReward CompletionReward { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public BuilderEventTimerId TimerId { get; set; }
    }
}