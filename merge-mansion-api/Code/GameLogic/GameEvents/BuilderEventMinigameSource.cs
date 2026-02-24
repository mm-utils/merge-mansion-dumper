using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventMinigameSource : IConfigItemSource<BuilderEventMinigameInfo, CoreSupportEventMinigameId>, IGameConfigSourceItem<CoreSupportEventMinigameId, BuilderEventMinigameInfo>, IHasGameConfigKey<CoreSupportEventMinigameId>
    {
        public CoreSupportEventMinigameId ConfigKey { get; set; }
        public BuilderEventCollectionId CollectionId { get; set; }
        public BuilderEventMode Mode { get; set; }
        public int CompletionRewardAmount { get; set; }
        public string CompletionRewardType { get; set; }
        public string CompletionRewardId { get; set; }
        public string CompletionRewardAux0 { get; set; }
        public string CompletionRewardAux1 { get; set; }
        public BuilderEventTimerId TimerId { get; set; }
    }
}