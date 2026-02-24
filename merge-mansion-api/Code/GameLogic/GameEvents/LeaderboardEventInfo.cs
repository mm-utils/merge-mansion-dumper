using System.Collections.Generic;
using GameLogic.Player.Items;
using GameLogic.Player.Requirements;
using GameLogic.Story;
using Metaplay.Core;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using Metaplay.Core.Offers;
using System;
using System.Runtime.Serialization;
using GameLogic.Decorations;
using GameLogic.Config;
using GameLogic.Player.Rewards;
using Metaplay.Core.Math;
using Merge;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("LeaderboardEvent", false, true)]
    [MetaBlockedMembers(new int[] { 10, 16 })]
    public class LeaderboardEventInfo : IMetaActivableConfigData<LeaderboardEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<LeaderboardEventId>, IHasGameConfigKey<LeaderboardEventId>, IMetaActivableInfo<LeaderboardEventId>, IBoardEventInfo, IHasRequirement, IBubbleBonusEvent, IEventSharedInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public LeaderboardEventId LeaderboardEventId { get; set; }

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
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public OfferPlacementId BoardShopPlacementId { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> RankingRewardLevelRefs { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> LevelRefs { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public StoryDefinitionId EnterBoardDialogue { get; set; }
        public LeaderboardEventId ConfigKey => LeaderboardEventId;

        [MetaMember(14, (MetaMemberFlags)0)]
        public StoryDefinitionId EndDialogue { get; set; }

        public LeaderboardEventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        [IgnoreDataMember]
        public BoardInfo Board { get; }

        [IgnoreDataMember]
        public IEnumerable<EventLevelInfo> Levels { get; }
        public OfferPlacementId BoardShopFlashPlacementId { get; }

        [IgnoreDataMember]
        DecorationInfo Code.GameLogic.GameEvents.IBoardEventInfo.ActiveDecoration { get; }

        [IgnoreDataMember]
        ExtendableEventParams Code.GameLogic.GameEvents.IBoardEventInfo.ExtendableEventParams { get; }

        [IgnoreDataMember]
        MetaRef<InAppProductInfo> Code.GameLogic.GameEvents.IBoardEventInfo.ExtensionInAppProduct { get; }

        [IgnoreDataMember]
        MetaDuration Code.GameLogic.GameEvents.IBoardEventInfo.ExtensionPurchaseSafetyMargin { get; }

        public LeaderboardEventInfo()
        {
        }

        public LeaderboardEventInfo(LeaderboardEventId leaderboardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, int secondaryEnergyAttachmentChance, List<MetaRef<EventLevelInfo>> rankingRewardLevelRefs, List<MetaRef<EventLevelInfo>> levelRefs, StoryDefinitionId enterBoardDialogue, StoryDefinitionId endDialogue)
        {
        }

        [MetaMember(15, (MetaMemberFlags)0)]
        public F32? BubbleBonusDivisor { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public MetaDuration? AuxEnergyUnitRestoreDuration { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public int AuxEnergyAttachmentChance { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public bool DisableBubbleBonus { get; set; }

        [IgnoreDataMember]
        MergeBoardId Code.GameLogic.GameEvents.IBoardEventInfo.MergeBoardId { get; }

        public LeaderboardEventInfo(LeaderboardEventId leaderboardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, List<MetaRef<EventLevelInfo>> rankingRewardLevelRefs, List<MetaRef<EventLevelInfo>> levelRefs, StoryDefinitionId enterBoardDialogue, StoryDefinitionId endDialogue, F32? bubbleBonusDivisor, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, bool disableBubbleBonus)
        {
        }

        [IgnoreDataMember]
        IStringId Code.GameLogic.GameEvents.IBoardEventInfo.BoardEventId { get; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public List<BubbleBonusInfo> SecondaryBoardBubbleBonus { get; set; }

        public LeaderboardEventInfo(LeaderboardEventId leaderboardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, List<MetaRef<EventLevelInfo>> rankingRewardLevelRefs, List<MetaRef<EventLevelInfo>> levelRefs, StoryDefinitionId enterBoardDialogue, StoryDefinitionId endDialogue, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId eventGroupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonus)
        {
        }

        [MetaMember(22, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public LeaderboardEventInfo(LeaderboardEventId leaderboardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, List<MetaRef<EventLevelInfo>> rankingRewardLevelRefs, List<MetaRef<EventLevelInfo>> levelRefs, StoryDefinitionId enterBoardDialogue, StoryDefinitionId endDialogue, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId eventGroupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonus, int priority)
        {
        }

        [MetaMember(23, (MetaMemberFlags)0)]
        [ServerOnly]
        public LeaderboardEventMatchmakingBucketsId MatchmakingBuckets { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public LeaderboardEventInfo(LeaderboardEventId leaderboardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, List<MetaRef<EventLevelInfo>> rankingRewardLevelRefs, List<MetaRef<EventLevelInfo>> levelRefs, StoryDefinitionId enterBoardDialogue, StoryDefinitionId endDialogue, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId eventGroupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonus, int priority, LeaderboardEventMatchmakingBucketsId matchmakingBuckets, EventCategoryInfo categoryInfo)
        {
        }

        [MetaMember(25, (MetaMemberFlags)0)]
        public bool ForceLocationTravel { get; set; }

        public LeaderboardEventInfo(LeaderboardEventId leaderboardEventId, string nameLocId, string displayName, string description, MetaActivableParams activableParams, MetaRef<BoardInfo> boardRef, MetaRef<ItemDefinition> portalItemRef, PlayerRequirement unlockRequirement, OfferPlacementId boardShopPlacementId, List<MetaRef<EventLevelInfo>> rankingRewardLevelRefs, List<MetaRef<EventLevelInfo>> levelRefs, StoryDefinitionId enterBoardDialogue, StoryDefinitionId endDialogue, MetaDuration? auxEnergyUnitRestoreDuration, int auxEnergyAttachmentChance, EventGroupId eventGroupId, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonus, int priority, LeaderboardEventMatchmakingBucketsId matchmakingBuckets, EventCategoryInfo categoryInfo, bool forceLocationTravel)
        {
        }

        [MetaMember(7, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixRef")]
        public ItemDef PortalItemDef { get; set; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}