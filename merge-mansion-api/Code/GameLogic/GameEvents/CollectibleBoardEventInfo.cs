using System.Collections.Generic;
using GameLogic.Player.Items;
using GameLogic.Player.Requirements;
using GameLogic.Story;
using Metaplay.Core;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using Metaplay.Core.Offers;
using GameLogic.Decorations;
using System;
using GameLogic.Config;
using GameLogic.Player.Rewards;
using System.Runtime.Serialization;
using System.Reflection;
using Metaplay.Core.Math;
using Merge;
using GameLogic.Cutscenes;
using GameLogic.MergeChains;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;
using Code.GameLogic.ProgressionTracks;

namespace Code.GameLogic.GameEvents
{
    [DefaultMember("Item")]
    [MetaSerializable]
    [MetaActivableConfigData("CollectibleBoardEvent", false, true)]
    [MetaBlockedMembers(new int[] { 6, 7, 13, 24, 27 })]
    public class CollectibleBoardEventInfo : IMetaActivableConfigData<CollectibleBoardEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<CollectibleBoardEventId>, IHasGameConfigKey<CollectibleBoardEventId>, IMetaActivableInfo<CollectibleBoardEventId>, ILevelBoardEventInfo, ILevelEventInfo, IBoardEventInfo, IHasRequirement, IBubbleBonusEvent, IEventSharedInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CollectibleBoardEventId CollectibleBoardEventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> LevelRefs { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> RecurringLevelRefs { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public Dictionary<EventLevelId, MetaRef<EventLevelInfo>> FallbackLevelRefs { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public StoryDefinitionId EnterBoardDialogue { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public StoryDefinitionId EndDialogue { get; set; }
        public CollectibleBoardEventId ConfigKey => CollectibleBoardEventId;

        [MetaMember(15, (MetaMemberFlags)0)]
        private MetaRef<DecorationInfo> ActiveDecorationRef { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public List<int> ProgressionPopupHeaderImageLevels { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public MetaRef<EventTaskInfo> EventInitTask { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public List<MetaRef<EventTaskInfo>> EventTasks { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        private MetaRef<StoryElementInfo> StartDialogueRef { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public ExtendableEventParams ExtendableEventParams { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> ExtensionInAppProduct { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public MetaDuration ExtensionPurchaseSafetyMargin { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        public List<PlayerReward> ExtensionRewards { get; set; }
        public CollectibleBoardEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        [IgnoreDataMember]
        public DecorationInfo ActiveDecoration { get; }

        [IgnoreDataMember]
        public StoryElementInfo StartDialogue { get; }

        [IgnoreDataMember]
        public EventTaskInfo Item { get; }

        public CollectibleBoardEventInfo()
        {
        }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards)
        {
        }

        [MetaMember(25, (MetaMemberFlags)0)]
        public PlayerRequirement PreviewRequirement { get; set; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, int secondaryEnergyAttachmentChance, PlayerRequirement previewRequirement)
        {
        }

        [MetaMember(26, (MetaMemberFlags)0)]
        public F32? BubbleBonusDivisor { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public MetaDuration? AuxEnergyUnitRestoreDuration { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        public int AuxEnergyAttachmentChance { get; set; }

        [MetaMember(30, (MetaMemberFlags)0)]
        public bool DisableBubbleBonus { get; set; }

        [IgnoreDataMember]
        MergeBoardId Code.GameLogic.GameEvents.IBoardEventInfo.MergeBoardId { get; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, F32? bubbleBonusDivisor, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, bool disableBubbleBonus)
        {
        }

        [MetaMember(31, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, F32? bubbleBonusDivisor, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, bool disableBubbleBonus, EventGroupId groupId)
        {
        }

        [MetaMember(32, (MetaMemberFlags)0)]
        public List<MetaRef<BoardInfo>> BoardRefs { get; set; }

        [MetaMember(33, (MetaMemberFlags)0)]
        public List<OfferPlacementId> BoardShopPlacementIds { get; set; }

        [IgnoreDataMember]
        public BoardInfo InitialBoard { get; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, F32? bubbleBonusDivisor, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, bool disableBubbleBonus, EventGroupId groupId)
        {
        }

        [IgnoreDataMember]
        IStringId Code.GameLogic.GameEvents.IBoardEventInfo.BoardEventId { get; }

        [IgnoreDataMember]
        public IStringId LevelEventId { get; }

        [MetaMember(34, (MetaMemberFlags)0)]
        private MetaRef<CutsceneInfo> StartCutsceneRef { get; set; }

        [MetaMember(35, (MetaMemberFlags)0)]
        public List<BubbleBonusInfo> SecondaryBoardBubbleBonus { get; set; }

        [IgnoreDataMember]
        public CutsceneInfo StartCutscene { get; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses)
        {
        }

        [MetaMember(36, (MetaMemberFlags)0)]
        public bool ShouldReset { get; set; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset)
        {
        }

        [MetaMember(37, (MetaMemberFlags)0)]
        public MergeChainId PersistingChainID { get; set; }

        [MetaMember(38, (MetaMemberFlags)0)]
        public LuckyType LuckyType { get; set; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset, MergeChainId persistingChainID, LuckyType luckyType)
        {
        }

        [MetaMember(39, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }
        public string EventId { get; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset, MergeChainId persistingChainID, LuckyType luckyType, int priority)
        {
        }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, List<MetaRef<ItemDefinition>> portalItemRefs, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset, MergeChainId persistingChainID, LuckyType luckyType, int priority)
        {
        }

        [MetaMember(41, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        [MetaMember(42, (MetaMemberFlags)0)]
        public string ConnectedMinigameId { get; set; }
        public List<PlayerReward> ConfiguredExtensionRewardsForValidation { get; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, List<MetaRef<ItemDefinition>> portalItemRefs, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset, MergeChainId persistingChainID, LuckyType luckyType, int priority, EventCategoryInfo categoryInfo, string connectedMinigameId)
        {
        }

        [MetaMember(43, (MetaMemberFlags)0)]
        public string PrefabsOverride { get; set; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, List<MetaRef<ItemDefinition>> portalItemRefs, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset, MergeChainId persistingChainID, LuckyType luckyType, int priority, EventCategoryInfo categoryInfo, string connectedMinigameId, string prefabsOverride)
        {
        }

        [MetaMember(44, (MetaMemberFlags)0)]
        public bool ForceLocationTravel { get; set; }

        public CollectibleBoardEventInfo(CollectibleBoardEventId collectibleBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<BoardInfo>> boardRefs, List<MetaRef<ItemDefinition>> portalItemRefs, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, List<OfferPlacementId> boardShopPlacementIds, StoryDefinitionId endDialogue, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, StoryDefinitionId startDialogue, CutsceneId startCutscene, ExtendableEventParams extendableEventParams, MetaRef<InAppProductInfo> extensionInAppProduct, MetaDuration extensionPurchaseSafetyMargin, IEnumerable<PlayerReward> extensionRewards, PlayerRequirement previewRequirement, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId groupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonuses, bool shouldReset, MergeChainId persistingChainID, LuckyType luckyType, int priority, EventCategoryInfo categoryInfo, string connectedMinigameId, string prefabsOverride, bool forceLocationTravel)
        {
        }

        [MetaMember(40, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRefList")]
        public List<ItemDef> PortalItemDefs { get; set; }
        public Option<List<ItemDef>> PortalItemRefsOption { get; }

        [MetaMember(45, (MetaMemberFlags)0)]
        public List<ProgressionTrackId> EventProgressionTracks { get; set; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}