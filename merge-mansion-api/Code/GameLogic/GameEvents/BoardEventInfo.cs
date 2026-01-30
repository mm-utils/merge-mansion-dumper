using System.Collections.Generic;
using GameLogic.Config;
using GameLogic.ConfigPrefabs;
using GameLogic.Player.Director.Config;
using GameLogic.Story;
using Metaplay.Core;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using Metaplay.Core.Offers;
using Code.GameLogic.Config;
using System;
using GameLogic.Player.Requirements;
using GameLogic.Decorations;
using GameLogic.Player.Rewards;
using System.Runtime.Serialization;
using GameLogic;
using System.Reflection;
using Merge;
using Metaplay.Core.Math;
using GameLogic.Player;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [DefaultMember("Item")]
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 10, 11, 13, 14, 16, 33, 34, 45 })]
    [MetaActivableConfigData("BoardEvent", false, true)]
    public class BoardEventInfo : IMetaActivableConfigData<EventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<EventId>, IHasGameConfigKey<EventId>, IMetaActivableInfo<EventId>, IValidatable, IBoardEventInfo, IHasRequirement, IEventSharedInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public EventId EventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaRef<EventCurrencyInfo> EventCurrencyInfo { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MetaRef<BoardInfo> BoardInfo { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public MetaRef<EventTaskInfo> EventInitTask { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<MetaRef<EventTaskInfo>> EventTasks { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public MetaRef<EventLevels> Levels { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public int? PortalItem { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public string NameLocalizationId { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public OfferPlacementId BoardShopPlacementId { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public ExtendableEventParams ExtendableEventParams { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> ExtensionInAppProduct { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public MetaDuration ExtensionPurchaseSafetyMargin { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public ConfigPrefabId InfoPopupId { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public ConfigPrefabId TaskProgressionId { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        public ConfigPrefabId TaskGoalItemId { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public MetaRef<ShopEventInfo> HintedShopEvent { get; set; }

        [MetaMember(25, (MetaMemberFlags)0)]
        public StoryDefinitionId StartEventDialogue { get; set; }

        [MetaMember(26, (MetaMemberFlags)0)]
        public ConfigPrefabId StartPopupId { get; set; }

        [MetaMember(27, (MetaMemberFlags)0)]
        public ConfigPrefabId TeasePopupId { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public ConfigPrefabId IntroPopupId { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        public ConfigPrefabId ExtendPopupId { get; set; }

        [MetaMember(30, (MetaMemberFlags)0)]
        public ConfigPrefabId EndPopupId { get; set; }

        [MetaMember(31, (MetaMemberFlags)0)]
        public ConfigPrefabId HudButtonId { get; set; }

        [MetaMember(32, (MetaMemberFlags)0)]
        public ConfigPrefabId RewardInfoPopupId { get; set; }

        [MetaMember(35, (MetaMemberFlags)0)]
        public bool VisualiseEventPoints { get; set; }

        [MetaMember(36, (MetaMemberFlags)0)]
        public ConfigPrefabId TaskItemCheckmarkId { get; set; }

        [MetaMember(37, (MetaMemberFlags)0)]
        private List<IDirectorAction> StartActions { get; set; }

        [MetaMember(38, (MetaMemberFlags)0)]
        private List<IDirectorAction> EndActions { get; set; }
        public EventId ConfigKey => EventId;
        public IEnumerable<IDirectorAction> OnStart => StartActions;
        public IEnumerable<IDirectorAction> OnEnd => EndActions;

        [MetaMember(39, (MetaMemberFlags)0)]
        public string BoardTransitionSfxOverride { get; set; }

        [MetaMember(40, (MetaMemberFlags)0)]
        public PlayerRequirement PreviewRequirement { get; set; }

        [MetaMember(41, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(42, (MetaMemberFlags)0)]
        private MetaRef<DecorationInfo> ActiveDecorationRef { get; set; }

        [MetaMember(43, (MetaMemberFlags)0)]
        public bool GivePortalItemWithoutTask { get; set; }

        [MetaMember(44, (MetaMemberFlags)0)]
        public List<PlayerReward> ExtensionRewards { get; set; }
        public EventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public bool HasCustomCurrency { get; }
        public bool HasCustomBoard { get; }
        public bool HasInfoPopup { get; }
        public bool HasStartPopup { get; }
        public bool HasTeasePopup { get; }
        public bool HasIntroPopup { get; }
        public bool HasHudButton { get; }
        public bool HasEndPopup { get; }
        public bool HasTaskItemCheckmark { get; }
        public OfferPlacementId BoardShopFlashPlacementId { get; }

        [IgnoreDataMember]
        public EventTaskInfo Item { get; }

        [IgnoreDataMember]
        public DecorationInfo ActiveDecoration { get; }

        public BoardEventInfo()
        {
        }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, ConfigPrefabId rewardClaimPopupId, ConfigPrefabId rewardChestPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards)
        {
        }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, ConfigPrefabId rewardClaimPopupId, ConfigPrefabId rewardChestPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, int secondaryEnergyAttachmentChance)
        {
        }

        [MetaMember(46, (MetaMemberFlags)0)]
        public string PrefabsId { get; set; }

        [IgnoreDataMember]
        MergeBoardId Code.GameLogic.GameEvents.IBoardEventInfo.MergeBoardId { get; }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, ConfigPrefabId rewardClaimPopupId, ConfigPrefabId rewardChestPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, string prefabsId)
        {
        }

        [MetaMember(47, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, ConfigPrefabId rewardClaimPopupId, ConfigPrefabId rewardChestPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, string prefabsId, EventGroupId groupId)
        {
        }

        [MetaMember(48, (MetaMemberFlags)0)]
        public bool HasDynamicTasks { get; set; }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, string prefabsId, EventGroupId groupId, bool hasDynamicTasks)
        {
        }

        [IgnoreDataMember]
        IStringId Code.GameLogic.GameEvents.IBoardEventInfo.BoardEventId { get; }

        [MetaMember(49, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, string prefabsId, EventGroupId groupId, bool hasDynamicTasks, int priority)
        {
        }

        [MetaMember(50, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, string prefabsId, EventGroupId groupId, bool hasDynamicTasks, int priority, EventCategoryInfo categoryInfo)
        {
        }

        [MetaMember(51, (MetaMemberFlags)0)]
        public bool ForceLocationTravel { get; set; }

        public BoardEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaRef<BoardInfo> boardInfo, MetaRef<EventTaskInfo> eventInitTask, List<MetaRef<EventTaskInfo>> eventTasks, MetaRef<EventLevels> eventLevels, int? portalItem, string nameLocId, OfferPlacementId offerPlacementId, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId infoPopupId, ConfigPrefabId taskProgressionId, ConfigPrefabId taskGoalItemId, StoryDefinitionId startEventDialogue, MetaRef<ShopEventInfo> hintedShopEvents, ConfigPrefabId startPopupId, ConfigPrefabId teasePopupId, ConfigPrefabId introPopupId, ConfigPrefabId extendPopupId, ConfigPrefabId endPopupId, ConfigPrefabId hudButtonId, ConfigPrefabId rewardInfoPopupId, bool visualiseEventPoints, ConfigPrefabId taskItemCheckmarkId, List<IDirectorAction> startActions, List<IDirectorAction> endActions, string boardTransitionSfxOverride, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, DecorationId activeDecoration, bool givePortalItemWithoutTask, IEnumerable<PlayerReward> extensionRewards, string prefabsId, EventGroupId groupId, bool hasDynamicTasks, int priority, EventCategoryInfo categoryInfo, bool forceLocationTravel)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}