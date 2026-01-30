using System.Collections.Generic;
using GameLogic.Area;
using GameLogic.Merge;
using GameLogic.Player.Director.Config;
using GameLogic.Player.Requirements;
using GameLogic.Player.Rewards;
using Metaplay.Core;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using System.Runtime.Serialization;
using System;
using Merge;
using GameLogic.Config.Map.Characters;
using GameLogic.Hotspots.CardStack;
using Code.GameLogic.Hotspots;
using Game.Cloud.Config;
using GameLogic.TaskLists;
using Code.GameLogic.Config;

namespace GameLogic.Hotspots
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 25 })]
    public class HotspotDefinition : IGameConfigData<HotspotId>, IGameConfigData, IHasGameConfigKey<HotspotId>, IValidatable, IHotspotDefinition, IHasRequirements
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public HotspotId Id { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public HotspotType Type { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaRef<AreaInfo> AreaRef { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MergeBoardId MergeBoardId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<PlayerRequirement> RequirementsList { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<HotspotDef> UnlockingParentRefs { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<IDirectorAction> CompletionActions { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<IDirectorAction> FinalizationActions { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public List<IDirectorAction> AppearActions { get; set; }
        public HotspotId ConfigKey => Id;

        [IgnoreDataMember]
        public bool IsAreaUnlockHotspot { get; }

        [IgnoreDataMember]
        public IEnumerable<PlayerRequirement> Requirements { get; }

        public HotspotDefinition()
        {
        }

        public HotspotDefinition(HotspotId id, HotspotType type, AreaId area, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions)
        {
        }

        [MetaMember(11, (MetaMemberFlags)0)]
        private MetaRef<MapSpotInfo> MapSpotRef { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public TaskGroupId TaskGroupId { get; set; }

        [IgnoreDataMember]
        public bool IsMergeGoalHotspot { get; }

        [IgnoreDataMember]
        public MapSpotInfo MapSpot { get; }

        [IgnoreDataMember]
        public bool BelongsToTaskGroup { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId)
        {
        }

        [MetaMember(13, (MetaMemberFlags)0)]
        public List<PlayerRequirement> UnlockRequirementsList { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public bool IsIndependentTask { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public int AppearActionMax { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public int CompleteActionMax { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public HotspotDef CompleteFocusHotspotRef { get; set; }

        [IgnoreDataMember]
        public bool IsRepeatableTask { get; }

        [IgnoreDataMember]
        public List<PlayerRequirement> UnlockRequirements { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, int completeActionMax, HotspotId completeFocusHotspotId)
        {
        }

        [MetaMember(18, (MetaMemberFlags)0)]
        public List<MetaRef<MapCharacterEventDefinition>> AppearMapCharactersEventsRefs { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public List<MetaRef<MapCharacterEventDefinition>> CompleteMapCharactersEventsRefs { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public MetaDuration BonusTimerDuration { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public List<PlayerReward> BonusRewards { get; set; }

        [IgnoreDataMember]
        public IEnumerable<MapCharacterEventDefinition> AppearMapCharactersEvents { get; }

        [IgnoreDataMember]
        public MapCharacterType AppearMapCharacter { get; }

        [IgnoreDataMember]
        public IEnumerable<MapCharacterEventDefinition> CompleteMapCharactersEvents { get; }

        [IgnoreDataMember]
        public MapCharacterType CompleteMapCharacter { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration)
        {
        }

        [IgnoreDataMember]
        public bool HasVisualCompleteActions { get; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public string CompleteVFXId { get; set; }

        [IgnoreDataMember]
        public bool IsOpenUIHotspot { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId)
        {
        }

        [MetaMember(23, (MetaMemberFlags)0)]
        private MetaRef<CardStackInfo> CardStackRef { get; set; }

        [IgnoreDataMember]
        public bool IsCardStackTask { get; }

        [IgnoreDataMember]
        public CardStackInfo CardStackInfo { get; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public string DescriptionLocalizationId { get; set; }

        [IgnoreDataMember]
        public bool IsEventHotspot { get; }

        [IgnoreDataMember]
        public bool IsLocationTravelHotspot { get; }

        [IgnoreDataMember]
        public string DescriptionLocId { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId)
        {
        }

        [MetaMember(26, (MetaMemberFlags)0)]
        private MetaRef<AreaInfo> AreaInfoOverride { get; set; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId, AreaId areaInfoOverride)
        {
        }

        [MetaMember(27, (MetaMemberFlags)0)]
        private CustomHotspotTableId CustomHotspotTableId { get; set; }

        [IgnoreDataMember]
        public bool IsIllustrationParentTask { get; }

        [IgnoreDataMember]
        public bool IsIllustrationChildTask { get; }

        [IgnoreDataMember]
        public CustomHotspotTableId HotspotTableId { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId, AreaId areaInfoOverride, CustomHotspotTableId customHotspotTableId)
        {
        }

        [MetaMember(28, (MetaMemberFlags)0)]
        public int SoloMilestoneHotspotValue { get; set; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId, AreaId areaInfoOverride, int soloMilestoneHotspotValue, CustomHotspotTableId customHotspotTableId)
        {
        }

        [MetaMember(29, (MetaMemberFlags)0)]
        public MultistepGroupId MultistepGroupId { get; set; }

        [MetaMember(30, (MetaMemberFlags)0)]
        private MetaRef<TaskGroupDefinition> TaskGroupRef { get; set; }

        [MetaMember(31, (MetaMemberFlags)0)]
        public int BoultonLeaguePoints { get; set; }

        [MetaMember(32, (MetaMemberFlags)0)]
        public bool DelayDebrisAnimation { get; set; }

        [IgnoreDataMember]
        public bool BelongsToMultistepGroup { get; }

        [IgnoreDataMember]
        public TaskGroupDefinition TaskGroup { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId, AreaId areaInfoOverride, int soloMilestoneHotspotValue, CustomHotspotTableId customHotspotTableId, MultistepGroupId multistepGroupId, int boultonLeaguePoints, bool delayDebrisAnimation)
        {
        }

        [MetaMember(33, (MetaMemberFlags)0)]
        public int Difficulty { get; set; }

        [MetaMember(34, (MetaMemberFlags)0)]
        public List<PlayerReward> DifficultyRewards { get; set; }

        [MetaMember(35, (MetaMemberFlags)0)]
        private MetaRef<CustomHotspotTablesInfo> CustomHotspotTableInfoRef { get; set; }

        [IgnoreDataMember]
        public bool IsDifficultTask { get; }

        [IgnoreDataMember]
        public CustomHotspotTablesInfo HotspotTableInfo { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId, AreaId areaInfoOverride, int soloMilestoneHotspotValue, CustomHotspotTableId customHotspotTableId, MultistepGroupId multistepGroupId, int boultonLeaguePoints, bool delayDebrisAnimation, int difficulty, List<PlayerReward> difficultyRewards)
        {
        }

        [MetaMember(36, (MetaMemberFlags)0)]
        public int Order { get; set; }

        [MetaMember(37, (MetaMemberFlags)0)]
        public TaskListId TaskListId { get; set; }

        [MetaMember(38, (MetaMemberFlags)0)]
        public List<string> Tags { get; set; }

        [IgnoreDataMember]
        public bool IsValidInAreaCompletion { get; }

        public HotspotDefinition(HotspotId id, HotspotType type, MergeBoardId mergeBoardId, List<PlayerRequirement> requirements, IEnumerable<HotspotId> unlockingParents, List<PlayerReward> rewards, List<IDirectorAction> completionActions, List<IDirectorAction> finalizationActions, List<IDirectorAction> appearActions, MapSpotId mapSpot, TaskGroupId taskGroupId, List<PlayerRequirement> unlockRequirements, bool isIndependentTask, int appearActionMax, List<MetaRef<MapCharacterEventDefinition>> appearMapCharactersEvents, int completeActionMax, HotspotId completeFocusHotspotId, List<MetaRef<MapCharacterEventDefinition>> completeMapCharactersEvents, List<PlayerReward> bonusRewards, MetaDuration bonusTimerDuration, string completeVFXId, string descriptionLocalizationId, LocationTravelId locationTravelId, AreaId areaInfoOverride, int soloMilestoneHotspotValue, CustomHotspotTableId customHotspotTableId, MultistepGroupId multistepGroupId, int boultonLeaguePoints, bool delayDebrisAnimation, int difficulty, List<PlayerReward> difficultyRewards, int order, TaskListId taskListId, List<string> tags)
        {
        }

        [MetaMember(39, (MetaMemberFlags)0)]
        private List<MetaRef<LocationTravelInfo>> LocationTravelInfosRefs { get; set; }

        [IgnoreDataMember]
        public IEnumerable<LocationTravelInfo> LocationTravelInfos { get; }

        [IgnoreDataMember]
        public LocationTravelInfo FirstLocationTravelInfo { get; }
    }
}