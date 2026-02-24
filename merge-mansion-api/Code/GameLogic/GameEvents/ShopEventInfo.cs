using System.Collections.Generic;
using GameLogic.Config;
using GameLogic.ConfigPrefabs;
using Metaplay.Core;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using Code.GameLogic.Config;
using GameLogic.Player.Requirements;
using System;
using System.Runtime.Serialization;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("ShopEvent", false, true)]
    [MetaBlockedMembers(new int[] { 6, 7, 8, 9, 12, 13, 14, 15, 21, 24, 25, 26, 27 })]
    public class ShopEventInfo : IMetaActivableConfigData<EventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<EventId>, IHasGameConfigKey<EventId>, IMetaActivableInfo<EventId>, IValidatable, IEventSharedInfo, IHasRequirement
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

        [MetaMember(10, (MetaMemberFlags)0)]
        public List<MetaRef<EventOfferInfo>> EventShopOfferInfos { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public MetaRef<EventLevels> Levels { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public List<MetaRef<BoardEventInfo>> HintedBoardEventInfos { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public ExtendableEventParams ExtendableEventParams { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public MetaDuration ExtensionPurchaseSafetyMargin { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> ExtensionInAppProduct { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public ConfigPrefabId EndPopupId { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        public ConfigPrefabId ShopPopupId { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public ConfigPrefabId HudButtonId { get; set; }
        public EventId ConfigKey => EventId;

        [MetaMember(29, (MetaMemberFlags)0)]
        public List<MetaRef<EventOfferSetInfo>> EventOfferSetInfos { get; set; }

        [MetaMember(30, (MetaMemberFlags)0)]
        public PlayerRequirement PreviewRequirement { get; set; }

        [MetaMember(31, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }
        public bool HasCustomCurrency { get; }
        public EventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public bool HasHudButton { get; }

        [IgnoreDataMember]
        public IEnumerable<EventOfferInfo> NonSetOffers { get; }

        [IgnoreDataMember]
        public IEnumerable<EventOfferSetInfo> OfferSets { get; }

        [IgnoreDataMember]
        public IEnumerable<EventOfferInfo> AllOffers { get; }

        public ShopEventInfo()
        {
        }

        public ShopEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<EventOfferInfo>> eventShopOfferInfos, MetaRef<EventLevels> eventLevels, MetaRef<EventCurrencyInfo> eventCurrencyInfo, List<MetaRef<BoardEventInfo>> hintedBoardEventInfos, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId endPopupId, ConfigPrefabId shopPopupId, ConfigPrefabId hudButtonId, List<MetaRef<EventOfferSetInfo>> eventOfferSetInfos, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement)
        {
        }

        [MetaMember(33, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        public ShopEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<EventOfferInfo>> eventShopOfferInfos, MetaRef<EventLevels> eventLevels, MetaRef<EventCurrencyInfo> eventCurrencyInfo, List<MetaRef<BoardEventInfo>> hintedBoardEventInfos, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId endPopupId, ConfigPrefabId shopPopupId, ConfigPrefabId hudButtonId, List<MetaRef<EventOfferSetInfo>> eventOfferSetInfos, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, EventGroupId groupId)
        {
        }

        [MetaMember(34, (MetaMemberFlags)0)]
        public string PrefabsId { get; set; }

        public ShopEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<EventOfferInfo>> eventShopOfferInfos, MetaRef<EventLevels> eventLevels, MetaRef<EventCurrencyInfo> eventCurrencyInfo, List<MetaRef<BoardEventInfo>> hintedBoardEventInfos, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId endPopupId, ConfigPrefabId shopPopupId, ConfigPrefabId hudButtonId, List<MetaRef<EventOfferSetInfo>> eventOfferSetInfos, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, EventGroupId groupId, string prefabsId)
        {
        }

        [MetaMember(35, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public ShopEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<EventOfferInfo>> eventShopOfferInfos, MetaRef<EventLevels> eventLevels, MetaRef<EventCurrencyInfo> eventCurrencyInfo, List<MetaRef<BoardEventInfo>> hintedBoardEventInfos, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId endPopupId, ConfigPrefabId shopPopupId, ConfigPrefabId hudButtonId, List<MetaRef<EventOfferSetInfo>> eventOfferSetInfos, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, EventGroupId groupId, string prefabsId, int priority)
        {
        }

        [MetaMember(36, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public ShopEventInfo(EventId eventId, string displayName, string description, MetaActivableParams activableParams, List<MetaRef<EventOfferInfo>> eventShopOfferInfos, MetaRef<EventLevels> eventLevels, MetaRef<EventCurrencyInfo> eventCurrencyInfo, List<MetaRef<BoardEventInfo>> hintedBoardEventInfos, ExtendableEventParams extendableEventParams, MetaDuration extensionPurchaseSafetyMargin, MetaRef<InAppProductInfo> extensionInAppProduct, ConfigPrefabId endPopupId, ConfigPrefabId shopPopupId, ConfigPrefabId hudButtonId, List<MetaRef<EventOfferSetInfo>> eventOfferSetInfos, PlayerRequirement previewRequirement, PlayerRequirement unlockRequirement, EventGroupId groupId, string prefabsId, int priority, EventCategoryInfo categoryInfo)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}