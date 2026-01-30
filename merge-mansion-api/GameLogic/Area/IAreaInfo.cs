using Metaplay.Core.Model;
using Metaplay.Core.Serialization;
using System;
using System.Collections.Generic;
using GameLogic.Player.Requirements;
using GameLogic.Player.Rewards;
using Game.Cloud.Config;
using Metaplay.Core;
using GameLogic.MergeChains;
using GameLogic.TaskLists;

namespace GameLogic.Area
{
    [MetaSerializable]
    [MetaDeserializationConvertFromConcreteDerivedType(typeof(AreaInfo))]
    public interface IAreaInfo
    {
        AreaId ConfigKey { get; }

        AreaId AreaId { get; }

        string TitleLocalizationId { get; }

        string CategoryLocalizationId { get; }

        List<PlayerRequirement> TeaseRequirements { get; }

        List<PlayerRequirement> UnlockRequirements { get; }

        List<PlayerReward> Rewards { get; }

        List<HotspotDef> HotspotsRefs { get; }

        string LockedDescriptionLocalizationId { get; }

        string UnlockedDescriptionLocalizationId { get; }

        string ShortDescriptionLocalizationId { get; }

        List<MetaRef<MapSpotInfo>> MapSpotRefs { get; }

        LocationId LocationId { get; }

        MergeChainId UnlockInstructionMergeChainId { get; }

        bool ForceTravelOnNotify { get; }

        bool IsTaskGroupV2Enabled { get; }

        List<MetaRef<TaskListInfo>> TaskListRefs { get; }

        int RowIndex { get; }

        AreaCompleteRewardStyle CompleteRewardStyle { get; }

        IEnumerable<MapSpotInfo> MapSpots { get; }

        AreaInfo UnlockInstructionAreaInfo { get; }

        AreaInfo NextAreaToUnlock { get; }

        bool IsStoryEventArea { get; }

        bool IsSeenItemRequiredArea { get; }

        IEnumerable<TaskListInfo> TaskLists { get; }

        bool HasTaskLists { get; }

        bool IsTaskGroupV2StartPopupEnabled { get; }
    }
}