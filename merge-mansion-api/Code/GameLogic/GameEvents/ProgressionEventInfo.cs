using System.Collections.Generic;
using GameLogic.Config;
using GameLogic.ConfigPrefabs;
using GameLogic.Story;
using Metaplay.Core;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using System;
using GameLogic.Player.Requirements;
using System.Runtime.Serialization;
using GameLogic;
using Metaplay.Core.Math;
using Code.GameLogic.Config;
using GameLogic.Cutscenes;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("ProgressionEvent", false, true)]
    [MetaBlockedMembers(new int[] { 5, 6 })]
    [MetaBlockedMembers(new int[] { 7, 8 })]
    [MetaBlockedMembers(new int[] { 14, 15, 16, 17, 18, 30 })]
    [MetaBlockedMembers(new int[] { 11, 20, 24, 25, 26, 27, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48 })]
    public class ProgressionEventInfo : IMetaActivableConfigData<ProgressionEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<ProgressionEventId>, IHasGameConfigKey<ProgressionEventId>, IMetaActivableInfo<ProgressionEventId>, IValidatable, IBubbleBonusEvent, IEventSharedInfo, IHasRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ProgressionEventId ProgressionEventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> FreeEventLevels { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<int> ChancesToSpawnEventItemPerLevel { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public int EventItem { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public int PremiumIAPOfferMinLevel { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public StoryDefinitionId IntroDialogue { get; set; }
        public ProgressionEventId ConfigKey => ProgressionEventId;

        [MetaMember(23, (MetaMemberFlags)0)]
        private List<MetaRef<EventLevelInfo>> FreeEventLevelRefs { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        public bool HasZeroLevel { get; set; }

        [MetaMember(31, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public StoryDefinitionId EndDialogue { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        private List<MetaRef<StoryElementInfo>> LevelRewardClaimedStoryRefs { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        private List<MetaRef<EventLevelInfo>> StoryTriggeringLevelRefs { get; set; }
        public ProgressionEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        [IgnoreDataMember]
        public IEnumerable<StoryElementInfo> LevelRewardClaimedStories { get; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> StoryTriggeringLevels { get; }

        [IgnoreDataMember]
        public int DefaultMaxLevelNumber { get; }

        [IgnoreDataMember]
        public int MinLevelNumber { get; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> AllEventLevels { get; }

        public ProgressionEventInfo()
        {
        }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement)
        {
        }

        [MetaMember(32, (MetaMemberFlags)0)]
        public F32? BubbleBonusDivisor { get; set; }

        [MetaMember(33, (MetaMemberFlags)0)]
        private List<MetaRef<ProgressionEventStreakRewards>> PremiumIAPStreakRewardRefs { get; set; }

        [IgnoreDataMember]
        private IEnumerable<ProgressionEventStreakRewards> PremiumIAPStreakRewards { get; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor)
        {
        }

        [MetaMember(34, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId)
        {
        }

        [MetaMember(35, (MetaMemberFlags)0)]
        private List<EventLevelId> TeasedEventLevelIds { get; set; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelId> TeasedEventLevels { get; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds)
        {
        }

        [MetaMember(36, (MetaMemberFlags)0)]
        public CutsceneId IntroCutscene { get; set; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene)
        {
        }

        [IgnoreDataMember]
        public List<BubbleBonusInfo> SecondaryBoardBubbleBonus { get; }

        [MetaMember(37, (MetaMemberFlags)0)]
        public string StartPopupDescId { get; set; }

        [MetaMember(38, (MetaMemberFlags)0)]
        public string EndPopupNoRewardsDescId { get; set; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string startPopupDescId, string endPopupNoRewardsDescId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene, string eventPrefabsId, string startHeaderBackgroundId, string endHeaderBackgroundId, string mainHubBadgeIconId, string todoItemHeaderBackgroundId, string progressionPopupHeaderBackgroundId, string eventRewardTagId, string uiCharacterItemId)
        {
        }

        [MetaMember(49, (MetaMemberFlags)0)]
        public List<int> PurchasePopupTriggeringLevels { get; set; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> Track1EventLevels { get; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> Track2EventLevels { get; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> BonusEventLevels { get; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string startPopupDescId, string endPopupNoRewardsDescId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene, string eventPrefabsId, string startHeaderBackgroundId, string endHeaderBackgroundId, string mainHubBadgeIconId, string todoItemHeaderBackgroundId, string progressionPopupHeaderBackgroundId, string eventRewardTagId, string uiCharacterItemId, string shopBundleHeaderId, List<int> purchasePopupTriggeringLevels, ProgressionEventV2Id v2Id)
        {
        }

        [MetaMember(50, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string startPopupDescId, string endPopupNoRewardsDescId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, MetaRef<InAppProductInfo> premiumIap, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventPerkInfo>> premiumIapPerks, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, List<MetaRef<EventLevelInfo>> premiumEventLevels, List<MetaRef<EventLevelInfo>> recurringFreeEventLevels, List<MetaRef<EventLevelInfo>> recurringPremiumEventLevels, int recurringLevelPointsIncrement, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene, string eventPrefabsId, string startHeaderBackgroundId, string endHeaderBackgroundId, string mainHubBadgeIconId, string todoItemHeaderBackgroundId, string progressionPopupHeaderBackgroundId, string eventRewardTagId, string uiCharacterItemId, string shopBundleHeaderId, List<int> purchasePopupTriggeringLevels, ProgressionEventV2Id v2Id, int priority)
        {
        }

        [MetaMember(51, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> Track1IAP { get; set; }

        [MetaMember(53, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> Track2IAP { get; set; }

        [MetaMember(55, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> UpgradeIAP { get; set; }

        [MetaMember(56, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> Track1EventLevelRefs { get; set; }

        [MetaMember(57, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> Track2EventLevelRefs { get; set; }

        [MetaMember(58, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> BonusEventLevelRefs { get; set; }

        [MetaMember(59, (MetaMemberFlags)0)]
        public bool IsBonusRewardSecret { get; set; }

        [MetaMember(52, (MetaMemberFlags)0)]
        public List<MetaRef<ProgressionEventPerkInfo>> Track1IAPPerkRefs { get; set; }

        [MetaMember(54, (MetaMemberFlags)0)]
        public List<MetaRef<ProgressionEventPerkInfo>> Track2IAPPerkRefs { get; set; }

        [MetaMember(60, (MetaMemberFlags)0)]
        public string PriceValueLocIdTrack1 { get; set; }

        [MetaMember(61, (MetaMemberFlags)0)]
        public string PriceValueLocIdTrack2 { get; set; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string startPopupDescId, string endPopupNoRewardsDescId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene, List<int> purchasePopupTriggeringLevels, int priority, MetaRef<InAppProductInfo> track1IAP, List<MetaRef<ProgressionEventPerkInfo>> track1IAPPerkRefs, MetaRef<InAppProductInfo> track2IAP, List<MetaRef<ProgressionEventPerkInfo>> track2IAPPerkRefs, MetaRef<InAppProductInfo> upgradeIAP, List<MetaRef<EventLevelInfo>> track1EventLevelRefs, List<MetaRef<EventLevelInfo>> track2EventLevelRefs, List<MetaRef<EventLevelInfo>> bonusEventLevelRefs, bool isBonusRewardSecret, string priceValueLocIdTrack1, string priceValueLocIdTrack2)
        {
        }

        [MetaMember(62, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string startPopupDescId, string endPopupNoRewardsDescId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene, List<int> purchasePopupTriggeringLevels, int priority, MetaRef<InAppProductInfo> track1IAP, List<MetaRef<ProgressionEventPerkInfo>> track1IAPPerkRefs, MetaRef<InAppProductInfo> track2IAP, List<MetaRef<ProgressionEventPerkInfo>> track2IAPPerkRefs, MetaRef<InAppProductInfo> upgradeIAP, List<MetaRef<EventLevelInfo>> track1EventLevelRefs, List<MetaRef<EventLevelInfo>> track2EventLevelRefs, List<MetaRef<EventLevelInfo>> bonusEventLevelRefs, bool isBonusRewardSecret, string priceValueLocIdTrack1, string priceValueLocIdTrack2, EventCategoryInfo categoryInfo)
        {
        }

        [IgnoreDataMember]
        public int MaxLevelNumberBonusIncluded { get; }

        [MetaMember(63, (MetaMemberFlags)0)]
        public bool ForceLocationTravel { get; set; }

        public ProgressionEventInfo(ProgressionEventId progressionEventId, string nameLocId, string startPopupDescId, string endPopupNoRewardsDescId, string displayName, string description, MetaActivableParams activableParams, List<int> chancesToSpawnEventPerItemLevel, int eventItem, int premiumIapOfferMinLevel, List<MetaRef<ProgressionEventStreakRewards>> premiumIAPStreakRewards, List<MetaRef<EventLevelInfo>> freeEventLevels, bool hasZeroLevel, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, List<MetaRef<StoryElementInfo>> levelRewardClaimedStories, List<MetaRef<EventLevelInfo>> storyTriggeringLevels, PlayerRequirement unlockRequirement, F32? bubbleBonusDivisor, EventGroupId groupId, List<EventLevelId> teasedEventLevelIds, CutsceneId introCutscene, List<int> purchasePopupTriggeringLevels, int priority, MetaRef<InAppProductInfo> track1IAP, List<MetaRef<ProgressionEventPerkInfo>> track1IAPPerkRefs, MetaRef<InAppProductInfo> track2IAP, List<MetaRef<ProgressionEventPerkInfo>> track2IAPPerkRefs, MetaRef<InAppProductInfo> upgradeIAP, List<MetaRef<EventLevelInfo>> track1EventLevelRefs, List<MetaRef<EventLevelInfo>> track2EventLevelRefs, List<MetaRef<EventLevelInfo>> bonusEventLevelRefs, bool isBonusRewardSecret, string priceValueLocIdTrack1, string priceValueLocIdTrack2, EventCategoryInfo categoryInfo, bool forceLocationTravel)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}