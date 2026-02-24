using Metaplay.Core.Model;
using System;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(4)]
    public class BuilderEventRewardId : ICoreSupportEventMinigameRewardId
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private CoreSupportEventMinigameId EventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private BuilderEventBuildLevelId BuildInfoId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private BuilderEventBuildId BuildId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private BuilderEventCollectionId CollectionId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public bool IsCompletionReward { get; set; }
        public Option<CoreSupportEventMinigameId> EventIdOption { get; }
        public Option<BuilderEventBuildLevelId> BuildInfoIdOption { get; }
        public Option<BuilderEventBuildId> BuildIdOption { get; }
        public Option<BuilderEventCollectionId> CollectionIdOption { get; }
    }
}