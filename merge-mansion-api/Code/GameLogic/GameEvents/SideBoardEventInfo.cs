using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using System.Reflection;
using Metaplay.Core.Config;
using System;
using Metaplay.Core;
using GameLogic.Player.Items;
using System.Collections.Generic;
using GameLogic.Story;
using GameLogic.Player.Requirements;
using Metaplay.Core.Offers;
using GameLogic.Decorations;
using GameLogic.Config;
using System.Runtime.Serialization;
using GameLogic.Player.Rewards;
using Merge;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [DefaultMember("Item")]
    [MetaSerializable]
    [MetaActivableConfigData("SideBoardEvent", false, true)]
    public class SideBoardEventInfo : IMetaActivableConfigData<SideBoardEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<SideBoardEventId>, IHasGameConfigKey<SideBoardEventId>, IMetaActivableInfo<SideBoardEventId>, IBoardEventInfo, IHasRequirement, IEventSharedInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public SideBoardEventId SideBoardEventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MetaRef<BoardInfo> BoardRef { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> LevelRefs { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public Dictionary<EventLevelId, MetaRef<EventLevelInfo>> FallbackLevelRefs { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public MetaRef<EventCurrencyInfo> EventCurrencyInfo { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public StoryDefinitionId EnterBoardDialogue { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public OfferPlacementId BoardShopPlacementId { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        private MetaRef<DecorationInfo> ActiveDecorationRef { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public List<int> ProgressionPopupHeaderImageLevels { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public MetaRef<EventTaskInfo> EventInitTask { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public List<MetaRef<EventTaskInfo>> EventTasks { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public int LimitResourceItem { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public string IsResourceItemAtMaxItemInfoAreaLocId { get; set; }

        [MetaMember(25, (MetaMemberFlags)0)]
        public string IsResourceItemAtMaxItemInfoAreaPortalLocId { get; set; }

        [MetaMember(26, (MetaMemberFlags)0)]
        public List<EventTaskLocEntry> EndPopupOptions { get; set; }

        [MetaMember(27, (MetaMemberFlags)0)]
        public ExtendableEventParams ExtendableEventParams { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public MetaDuration? ShowTimeInCalendarPopupAfterFinish { get; set; }
        public bool HasCustomCurrency { get; }
        public SideBoardEventId ConfigKey => SideBoardEventId;
        public SideBoardEventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        [IgnoreDataMember]
        public BoardInfo Board { get; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> Levels { get; }

        [IgnoreDataMember]
        public int SecondaryEnergyAttachmentChance { get; }
        public MetaRef<InAppProductInfo> ExtensionInAppProduct { get; }
        public MetaDuration ExtensionPurchaseSafetyMargin { get; }
        public OfferPlacementId BoardShopFlashPlacementId { get; }
        public OfferPlacementId BoardShopEventCurrencyPlacementId { get; }

        [IgnoreDataMember]
        IStringId Code.GameLogic.GameEvents.IBoardEventInfo.BoardEventId { get; }

        [IgnoreDataMember]
        MergeBoardId Code.GameLogic.GameEvents.IBoardEventInfo.MergeBoardId { get; }

        [IgnoreDataMember]
        public DecorationInfo ActiveDecoration { get; }

        [IgnoreDataMember]
        public EventTaskInfo Item { get; }

        public SideBoardEventInfo()
        {
        }

        public SideBoardEventInfo(SideBoardEventId sideBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, ExtendableEventParams extendableEventParams, int limitResourceItem, MetaRef<ItemDefinition> resourceItemRef, MetaRef<ItemDefinition> resourceItemCollectableRef, MetaRef<ItemDefinition> resourceItemSpawnerRef, MetaRef<ItemDefinition> emptySinkResourceItemRef, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnBoard, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnItemInfoArea, string isResourceItemAtMaxItemInfoAreaLocId, string isResourceItemAtMaxItemInfoAreaPortalLocId, List<EventTaskLocEntry> endPopupOptions, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaDuration? showTimeInCalendarPopupAfterFinish)
        {
        }

        [MetaMember(30, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        public SideBoardEventInfo(SideBoardEventId sideBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, Dictionary<MetaRef<EventLevelInfo>, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, ExtendableEventParams extendableEventParams, int limitResourceItem, MetaRef<ItemDefinition> resourceItemRef, MetaRef<ItemDefinition> resourceItemCollectableRef, MetaRef<ItemDefinition> resourceItemSpawnerRef, MetaRef<ItemDefinition> emptySinkResourceItemRef, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnBoard, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnItemInfoArea, string isResourceItemAtMaxItemInfoAreaLocId, string isResourceItemAtMaxItemInfoAreaPortalLocId, List<EventTaskLocEntry> endPopupOptions, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaDuration? showTimeInCalendarPopupAfterFinish, EventGroupId groupId)
        {
        }

        public SideBoardEventInfo(SideBoardEventId sideBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, ExtendableEventParams extendableEventParams, int limitResourceItem, MetaRef<ItemDefinition> resourceItemRef, MetaRef<ItemDefinition> resourceItemCollectableRef, MetaRef<ItemDefinition> resourceItemSpawnerRef, MetaRef<ItemDefinition> emptySinkResourceItemRef, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnBoard, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnItemInfoArea, string isResourceItemAtMaxItemInfoAreaLocId, string isResourceItemAtMaxItemInfoAreaPortalLocId, List<EventTaskLocEntry> endPopupOptions, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaDuration? showTimeInCalendarPopupAfterFinish, EventGroupId groupId)
        {
        }

        [MetaMember(31, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public SideBoardEventInfo(SideBoardEventId sideBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, ExtendableEventParams extendableEventParams, int limitResourceItem, MetaRef<ItemDefinition> resourceItemRef, MetaRef<ItemDefinition> resourceItemCollectableRef, MetaRef<ItemDefinition> resourceItemSpawnerRef, MetaRef<ItemDefinition> emptySinkResourceItemRef, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnBoard, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnItemInfoArea, string isResourceItemAtMaxItemInfoAreaLocId, string isResourceItemAtMaxItemInfoAreaPortalLocId, List<EventTaskLocEntry> endPopupOptions, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaDuration? showTimeInCalendarPopupAfterFinish, EventGroupId groupId, int priority)
        {
        }

        [MetaMember(32, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public SideBoardEventInfo(SideBoardEventId sideBoardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, List<MetaRef<EventLevelInfo>> levelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, StoryDefinitionId enterBoardDialogue, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, DecorationId activeDecoration, List<int> progressionPopupHeaderImageLevels, string initTask, List<MetaRef<EventTaskInfo>> eventTasks, ExtendableEventParams extendableEventParams, int limitResourceItem, MetaRef<ItemDefinition> resourceItemRef, MetaRef<ItemDefinition> resourceItemCollectableRef, MetaRef<ItemDefinition> resourceItemSpawnerRef, MetaRef<ItemDefinition> emptySinkResourceItemRef, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnBoard, List<MetaRef<ItemDefinition>> itemRefsDisplayingResourceItemCountOnItemInfoArea, string isResourceItemAtMaxItemInfoAreaLocId, string isResourceItemAtMaxItemInfoAreaPortalLocId, List<EventTaskLocEntry> endPopupOptions, MetaRef<EventCurrencyInfo> eventCurrencyInfo, MetaDuration? showTimeInCalendarPopupAfterFinish, EventGroupId groupId, int priority, EventCategoryInfo categoryInfo)
        {
        }

        [MetaMember(7, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef PortalItemDef { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ResourceItemDef { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ResourceItemSpawnerDef { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef EmptySinkResourceItemDef { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRefList")]
        public List<ItemDef> ItemDefsDisplayingResourceItemCountOnBoard { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRefList")]
        public List<ItemDef> ItemDefsDisplayingResourceItemCountOnItemInfoArea { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef ResourceItemCollectableDef { get; set; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}