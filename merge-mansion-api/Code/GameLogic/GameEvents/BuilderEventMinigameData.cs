using Metaplay.Core.Model;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventMinigameData : IBuilderEventMinigameData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int Level { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int BuildNumber { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int Points { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public BuilderEventCollectionId CollectionId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId CurrentMinigameId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public BuilderEventBuildId CurrentBuildId { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public BuilderEventModeData ModeData { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<BuilderEventBuildStateData> BuildStates { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public TimedRewardData TimedReward { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public bool HasSeenInfoPopup { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public CoreSupportEventId LastCoreSupportEventId { get; set; }
    }
}