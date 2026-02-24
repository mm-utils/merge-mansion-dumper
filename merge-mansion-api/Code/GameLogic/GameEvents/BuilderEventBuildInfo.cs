using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using GameLogic.Player.Rewards;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventBuildInfo : IGameConfigData<BuilderEventBuildLevelId>, IGameConfigData, IHasGameConfigKey<BuilderEventBuildLevelId>, IDebugBuilderEventBuildInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventBuildLevelId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public BuilderEventCollectionId CollectionId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int BuildNumber { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int LevelNumber { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int RequiredPoints { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public PlayerReward MilestoneReward { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<string> ModeSelectionId { get; set; }
    }
}