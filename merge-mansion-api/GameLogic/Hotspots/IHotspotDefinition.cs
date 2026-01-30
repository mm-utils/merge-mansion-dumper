using Metaplay.Core.Model;
using Metaplay.Core.Serialization;
using GameLogic.Player.Requirements;
using Merge;
using System.Collections.Generic;
using Game.Cloud.Config;
using GameLogic.Player.Rewards;
using GameLogic.Player.Director.Config;
using GameLogic.Area;
using System;
using GameLogic.TaskLists;
using Metaplay.Core;
using GameLogic.Config.Map.Characters;
using GameLogic.Hotspots.CardStack;
using Code.GameLogic.Hotspots;

namespace GameLogic.Hotspots
{
    [MetaSerializable]
    [MetaDeserializationConvertFromConcreteDerivedType(typeof(HotspotDefinition))]
    public interface IHotspotDefinition : IHasRequirements
    {
        HotspotId ConfigKey { get; }

        HotspotId Id { get; }

        HotspotType Type { get; }

        MergeBoardId MergeBoardId { get; }

        List<PlayerRequirement> RequirementsList { get; }

        List<HotspotDef> UnlockingParentRefs { get; }

        List<PlayerReward> Rewards { get; }

        List<IDirectorAction> CompletionActions { get; }

        List<IDirectorAction> FinalizationActions { get; }

        List<IDirectorAction> AppearActions { get; }

        TaskGroupId TaskGroupId { get; }

        List<PlayerRequirement> UnlockRequirementsList { get; }

        bool IsIndependentTask { get; }

        int AppearActionMax { get; }

        int CompleteActionMax { get; }

        HotspotDef CompleteFocusHotspotRef { get; }

        MultistepGroupId MultistepGroupId { get; }

        int Order { get; }

        TaskListId TaskListId { get; }

        List<MetaRef<MapCharacterEventDefinition>> AppearMapCharactersEventsRefs { get; }

        List<MetaRef<MapCharacterEventDefinition>> CompleteMapCharactersEventsRefs { get; }

        MetaDuration BonusTimerDuration { get; }

        List<PlayerReward> BonusRewards { get; }

        string CompleteVFXId { get; }

        string DescriptionLocalizationId { get; }

        int SoloMilestoneHotspotValue { get; }

        int BoultonLeaguePoints { get; }

        bool DelayDebrisAnimation { get; }

        int Difficulty { get; }

        List<PlayerReward> DifficultyRewards { get; }

        List<string> Tags { get; }

        bool IsAreaUnlockHotspot { get; }

        bool IsMergeGoalHotspot { get; }

        bool IsRepeatableTask { get; }

        bool IsEventHotspot { get; }

        bool IsOpenUIHotspot { get; }

        bool IsCardStackTask { get; }

        bool IsIllustrationParentTask { get; }

        bool IsIllustrationChildTask { get; }

        bool IsLocationTravelHotspot { get; }

        bool IsValidInAreaCompletion { get; }

        IEnumerable<PlayerRequirement> Requirements { get; }

        MapSpotInfo MapSpot { get; }

        List<PlayerRequirement> UnlockRequirements { get; }

        CardStackInfo CardStackInfo { get; }

        IEnumerable<LocationTravelInfo> LocationTravelInfos { get; }

        LocationTravelInfo FirstLocationTravelInfo { get; }

        CustomHotspotTableId HotspotTableId { get; }

        bool BelongsToMultistepGroup { get; }

        TaskGroupDefinition TaskGroup { get; }

        bool BelongsToTaskGroup { get; }

        bool IsDifficultTask { get; }

        CustomHotspotTablesInfo HotspotTableInfo { get; }

        IEnumerable<MapCharacterEventDefinition> AppearMapCharactersEvents { get; }

        MapCharacterType AppearMapCharacter { get; }

        IEnumerable<MapCharacterEventDefinition> CompleteMapCharactersEvents { get; }

        MapCharacterType CompleteMapCharacter { get; }

        bool HasVisualCompleteActions { get; }

        string DescriptionLocId { get; }
    }
}