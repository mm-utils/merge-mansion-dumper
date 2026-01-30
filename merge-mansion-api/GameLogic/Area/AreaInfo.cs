using System.Collections.Generic;
using GameLogic.Hotspots;
using GameLogic.Player.Requirements;
using GameLogic.Player.Rewards;
using Metaplay.Core;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using System.Runtime.Serialization;
using System;
using GameLogic.MergeChains;
using Game.Cloud.Config;
using GameLogic.TaskLists;

namespace GameLogic.Area
{
    [MetaSerializable]
    public class AreaInfo : IGameConfigData<AreaId>, IGameConfigData, IHasGameConfigKey<AreaId>, IAreaInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public AreaId AreaId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string TitleLocalizationId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string CategoryLocalizationId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<PlayerRequirement> TeaseRequirements { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<PlayerRequirement> UnlockRequirements { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<HotspotDef> HotspotsRefs { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public HotspotDef UnlockingHotspotRef { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public string LockedDescriptionLocalizationId { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public string UnlockedDescriptionLocalizationId { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public string ShortDescriptionLocalizationId { get; set; }
        public AreaId ConfigKey => AreaId;

        [IgnoreDataMember]
        private bool? isStoryEventArea;
        [IgnoreDataMember]
        public bool IsStoryEventArea { get; }

        [IgnoreDataMember]
        public bool IsSeenItemRequiredArea { get; }

        public AreaInfo()
        {
        }

        public AreaInfo(AreaId configKey, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, IEnumerable<HotspotId> hotspots, HotspotId unlockedBy)
        {
        }

        [MetaMember(13, (MetaMemberFlags)0)]
        public List<MetaRef<MapSpotInfo>> MapSpotRefs { get; set; }

        [IgnoreDataMember]
        public IEnumerable<MapSpotInfo> MapSpots { get; }

        public AreaInfo(AreaId configKey, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, IEnumerable<HotspotId> hotspots, IEnumerable<MapSpotId> mapSpots, HotspotId unlockedBy)
        {
        }

        public AreaInfo(AreaId configKey, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy)
        {
        }

        [MetaMember(14, (MetaMemberFlags)0)]
        public LocationId LocationId { get; set; }

        public AreaInfo(AreaId configKey, LocationId locationId, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy)
        {
        }

        [MetaMember(15, (MetaMemberFlags)0)]
        public MergeChainId UnlockInstructionMergeChainId { get; set; }

        public AreaInfo(AreaId configKey, LocationId locationId, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy, MergeChainId unlockInstructionMergeChain)
        {
        }

        [MetaMember(16, (MetaMemberFlags)0)]
        private MetaRef<AreaInfo> UnlockInstructionAreaInfoRefs { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        private MetaRef<AreaInfo> NextAreaToUnlockRefs { get; set; }

        [IgnoreDataMember]
        public AreaInfo UnlockInstructionAreaInfo { get; }

        [IgnoreDataMember]
        public AreaInfo NextAreaToUnlock { get; }

        public AreaInfo(AreaId configKey, LocationId locationId, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy, MergeChainId unlockInstructionMergeChain, MetaRef<AreaInfo> unlockInstructionArea, MetaRef<AreaInfo> nextAreaToUnlock)
        {
        }

        [MetaMember(18, (MetaMemberFlags)0)]
        public bool NotifyOnStart { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public bool ForceTravelOnNotify { get; set; }

        public AreaInfo(AreaId configKey, LocationId locationId, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy, MergeChainId unlockInstructionMergeChain, MetaRef<AreaInfo> unlockInstructionArea, MetaRef<AreaInfo> nextAreaToUnlock, bool notifyOnStart, bool forceTravelOnNotify)
        {
        }

        [MetaMember(20, (MetaMemberFlags)0)]
        public bool IsTaskGroupV2Enabled { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public List<MetaRef<TaskListInfo>> TaskListRefs { get; set; }

        [IgnoreDataMember]
        public IEnumerable<TaskListInfo> TaskLists { get; }

        [IgnoreDataMember]
        public bool HasTaskLists { get; }

        public AreaInfo(AreaId configKey, LocationId locationId, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy, MergeChainId unlockInstructionMergeChain, MetaRef<AreaInfo> unlockInstructionArea, MetaRef<AreaInfo> nextAreaToUnlock, bool notifyOnStart, bool forceTravelOnNotify, bool isTaskGroupV2Enabled, List<MetaRef<TaskListInfo>> taskListRefs)
        {
        }

        [MetaMember(22, (MetaMemberFlags)0)]
        public int RowIndex { get; set; }

        public AreaInfo(AreaId configKey, LocationId locationId, string titleLocalizationId, string categoryLocalizationId, List<PlayerRequirement> teaseRequirements, List<PlayerRequirement> unlockRequirements, List<PlayerReward> rewards, string lockedDescriptionLocalizationId, string unlockedDescriptionLocalizationId, string shortDescriptionLocalizationId, List<MetaRef<HotspotDefinition>> hotspots, List<MetaRef<MapSpotInfo>> mapSpots, HotspotId unlockedBy, MergeChainId unlockInstructionMergeChain, MetaRef<AreaInfo> unlockInstructionArea, MetaRef<AreaInfo> nextAreaToUnlock, bool notifyOnStart, bool forceTravelOnNotify, bool isTaskGroupV2Enabled, List<MetaRef<TaskListInfo>> taskListRefs, int rowIndex)
        {
        }

        [MetaMember(23, (MetaMemberFlags)0)]
        public AreaCompleteRewardStyle CompleteRewardStyle { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public bool IsTaskGroupV2StartPopupEnabled { get; set; }
    }
}