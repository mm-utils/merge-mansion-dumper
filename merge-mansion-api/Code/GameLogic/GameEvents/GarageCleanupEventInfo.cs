using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using Merge;
using GameLogic.Player.Requirements;
using System.Runtime.Serialization;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 10, 11, 12, 13, 15, 16 })]
    [MetaActivableConfigData("GarageCleanupEvent", false, true)]
    public class GarageCleanupEventInfo : IMetaActivableConfigData<GarageCleanupEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<GarageCleanupEventId>, IHasGameConfigKey<GarageCleanupEventId>, IMetaActivableInfo<GarageCleanupEventId>, IValidatable, IEventSharedInfo, IHasRequirement
    {
        public static GarageCleanupEventInfo.BoardSizeInfo BoardSize;
        [MetaMember(1, (MetaMemberFlags)0)]
        public GarageCleanupEventId GarageCleanupEventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<GarageCleanupBoardInfo> Boards { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<MetaRef<GarageCleanupPatternSetInfo>> PatternSets { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<int> SpawnerItems { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<int> BoardCosts { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<MetaRef<GarageCleanupRewardInfo>> SlotFillRewards { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public MergeBoardId MergeBoardId { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        private string PrefabsOverride { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public bool AlwaysShowPatternsAndRewards { get; set; }

        public GarageCleanupEventId ActivableId => ConfigKey;
        public GarageCleanupEventId ConfigKey => GarageCleanupEventId;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        [IgnoreDataMember]
        public bool HasSpawnerItems { get; }

        public GarageCleanupEventInfo()
        {
        }

        public GarageCleanupEventInfo(GarageCleanupEventId garageCleanupEventId, string displayName, string description, MetaActivableParams activableParams, List<GarageCleanupBoardInfo> boards, List<MetaRef<GarageCleanupPatternSetInfo>> patternSets, List<int> spawnerItems, List<int> boardCosts, List<MetaRef<GarageCleanupRewardInfo>> slotFillRewards, MergeBoardId mergeBoardId, PlayerRequirement unlockRequirement, string prefabsOverride, bool alwaysShowPatternsAndRewards)
        {
        }

        public readonly struct BoardSizeInfo
        {
            public readonly int Width;
            public readonly int Height;
            public int Size { get; }
        }

        [MetaMember(20, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        public GarageCleanupEventInfo(GarageCleanupEventId garageCleanupEventId, string displayName, string description, MetaActivableParams activableParams, List<GarageCleanupBoardInfo> boards, List<MetaRef<GarageCleanupPatternSetInfo>> patternSets, List<int> spawnerItems, List<int> boardCosts, List<MetaRef<GarageCleanupRewardInfo>> slotFillRewards, MergeBoardId mergeBoardId, PlayerRequirement unlockRequirement, string prefabsOverride, bool alwaysShowPatternsAndRewards, EventGroupId groupId)
        {
        }

        [MetaMember(21, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public GarageCleanupEventInfo(GarageCleanupEventId garageCleanupEventId, string displayName, string description, MetaActivableParams activableParams, List<GarageCleanupBoardInfo> boards, List<MetaRef<GarageCleanupPatternSetInfo>> patternSets, List<int> spawnerItems, List<int> boardCosts, List<MetaRef<GarageCleanupRewardInfo>> slotFillRewards, MergeBoardId mergeBoardId, PlayerRequirement unlockRequirement, string prefabsOverride, bool alwaysShowPatternsAndRewards, EventGroupId groupId, int priority)
        {
        }

        [MetaMember(22, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public GarageCleanupEventInfo(GarageCleanupEventId garageCleanupEventId, string displayName, string description, MetaActivableParams activableParams, List<GarageCleanupBoardInfo> boards, List<MetaRef<GarageCleanupPatternSetInfo>> patternSets, List<int> spawnerItems, List<int> boardCosts, List<MetaRef<GarageCleanupRewardInfo>> slotFillRewards, MergeBoardId mergeBoardId, PlayerRequirement unlockRequirement, string prefabsOverride, bool alwaysShowPatternsAndRewards, EventGroupId groupId, int priority, EventCategoryInfo categoryInfo)
        {
        }

        [MetaMember(23, (MetaMemberFlags)0)]
        public bool ForceLocationTravel { get; set; }

        public GarageCleanupEventInfo(GarageCleanupEventId garageCleanupEventId, string displayName, string description, MetaActivableParams activableParams, List<GarageCleanupBoardInfo> boards, List<MetaRef<GarageCleanupPatternSetInfo>> patternSets, List<int> spawnerItems, List<int> boardCosts, List<MetaRef<GarageCleanupRewardInfo>> slotFillRewards, MergeBoardId mergeBoardId, PlayerRequirement unlockRequirement, string prefabsOverride, bool alwaysShowPatternsAndRewards, EventGroupId groupId, int priority, EventCategoryInfo categoryInfo, bool forceLocationTravel)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}