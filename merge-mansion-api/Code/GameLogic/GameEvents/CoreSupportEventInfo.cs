using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using GameLogic.Player.Requirements;
using Metaplay.Core;
using GameLogic.Player.Items;
using System.Collections.Generic;
using Metacore.MergeMansion.Common.Options;
using GameLogic.Config;

namespace Code.GameLogic.GameEvents
{
    [MetaBlockedMembers(new int[] { 5 })]
    [MetaSerializable]
    [MetaActivableConfigData("CoreSupportEvent", false, true)]
    public class CoreSupportEventInfo : IMetaActivableConfigData<CoreSupportEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<CoreSupportEventId>, IHasGameConfigKey<CoreSupportEventId>, IMetaActivableInfo<CoreSupportEventId>, IValidatable, ICoreSupportEventInfo, IEventSharedInfo, ILevelEventInfo, IHasRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public CoreSupportEventType EventType { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        private CoreSupportEventMinigameId MinigameId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        private string AssetOverride { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        private string LocOverride { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public PlayerRequirement PreviewRequirement { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public CoreSupportEventTokenId TokenId { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public string TokenAsset { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public string TokenLocId { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public long TokensAtStart { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> LevelRefs { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> RecurringLevelRefs { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public Dictionary<EventLevelId, MetaRef<EventLevelInfo>> FallbackLevelRefs { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        private CoreSupportEventModeFeature ModeFeature { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        private CoreSupportEventSegmentFeature<EventGroupId> SegmentFeature { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        private CoreSupportEventCollectionId CollectionId { get; set; }
        public CoreSupportEventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public string SharedEventId { get; }
        public IStringId LevelEventId { get; }
        public List<int> ProgressionPopupHeaderImageLevels { get; }
        public Option<CoreSupportEventMinigameId> MinigameIdOption { get; }
        public string AssetId { get; }
        public string LocIdPrefix { get; }
        public Option<CoreSupportEventCollectionId> CollectionIdOption { get; }
        public string NameLocId { get; }
        public Option<CoreSupportEventModeFeature> ModeFeatureOption { get; }
        public Option<CoreSupportEventSegmentFeature<EventGroupId>> SegmentFeatureOption { get; }

        public CoreSupportEventInfo()
        {
        }

        public CoreSupportEventInfo(CoreSupportEventId configKey, string displayName, string description, MetaActivableParams activableParams, EventGroupId groupId, int priority, CoreSupportEventType eventType, CoreSupportEventMinigameId minigameId, string assetOverride, string locOverride, PlayerRequirement unlockRequirement, PlayerRequirement previewRequirement, MetaRef<ItemDefinition> portalItemRef, CoreSupportEventTokenId tokenId, string tokenAsset, string tokenLocId, long tokensAtStart, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, CoreSupportEventModeFeature modeFeature, EventCategoryInfo categoryInfo, CoreSupportEventSegmentFeature<EventGroupId> segmentFeature, CoreSupportEventCollectionId collectionId)
        {
        }

        [MetaMember(25, (MetaMemberFlags)0)]
        public CoreSupportEventStartPopupAction StartPopupAction { get; set; }

        [MetaMember(26, (MetaMemberFlags)0)]
        public CoreSupportEventTokenTarget FallbackTokenTarget { get; set; }

        [MetaMember(27, (MetaMemberFlags)0)]
        public CoreSupportEventTokenType TokenType { get; set; }

        public CoreSupportEventInfo(CoreSupportEventId configKey, string displayName, string description, MetaActivableParams activableParams, EventGroupId groupId, int priority, CoreSupportEventType eventType, CoreSupportEventMinigameId minigameId, string assetOverride, string locOverride, PlayerRequirement unlockRequirement, PlayerRequirement previewRequirement, MetaRef<ItemDefinition> portalItemRef, CoreSupportEventTokenId tokenId, string tokenAsset, string tokenLocId, long tokensAtStart, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, CoreSupportEventModeFeature modeFeature, EventCategoryInfo categoryInfo, CoreSupportEventSegmentFeature<EventGroupId> segmentFeature, CoreSupportEventCollectionId collectionId, CoreSupportEventStartPopupAction startPopupAction, CoreSupportEventTokenTarget fallbackTokenTarget, CoreSupportEventTokenType tokenType)
        {
        }

        [MetaMember(28, (MetaMemberFlags)0)]
        public bool ForceDisableInfoPanel { get; set; }

        public CoreSupportEventInfo(CoreSupportEventId configKey, string displayName, string description, MetaActivableParams activableParams, EventGroupId groupId, int priority, CoreSupportEventType eventType, CoreSupportEventMinigameId minigameId, string assetOverride, string locOverride, PlayerRequirement unlockRequirement, PlayerRequirement previewRequirement, MetaRef<ItemDefinition> portalItemRef, CoreSupportEventTokenId tokenId, string tokenAsset, string tokenLocId, long tokensAtStart, List<MetaRef<EventLevelInfo>> levelRefs, List<MetaRef<EventLevelInfo>> recurringLevelRefs, Dictionary<EventLevelId, MetaRef<EventLevelInfo>> fallbackLevelRefs, CoreSupportEventModeFeature modeFeature, EventCategoryInfo categoryInfo, CoreSupportEventSegmentFeature<EventGroupId> segmentFeature, CoreSupportEventCollectionId collectionId, CoreSupportEventStartPopupAction startPopupAction, CoreSupportEventTokenTarget fallbackTokenTarget, CoreSupportEventTokenType tokenType, bool forceDisableInfoPanel)
        {
        }

        [MetaMember(13, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        private ItemDef PortalItemDef { get; set; }
        public Option<CoreSupportEventTokenId> TokenIdOption { get; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}