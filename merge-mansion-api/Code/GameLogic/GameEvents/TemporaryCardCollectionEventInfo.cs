using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using GameLogic.Player.Requirements;
using System.Collections.Generic;
using GameLogic.CardCollection;
using GameLogic.Player.Rewards;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("TemporaryCardCollectionEvent", false, true)]
    public class TemporaryCardCollectionEventInfo : IMetaActivableConfigData<TemporaryCardCollectionEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<TemporaryCardCollectionEventId>, IHasGameConfigKey<TemporaryCardCollectionEventId>, IMetaActivableInfo<TemporaryCardCollectionEventId>, IHasRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public TemporaryCardCollectionEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<CardCollectionCardSetId> CardSetIds { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public CardCollectionBalanceId BalanceId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        private List<CardCollectionEvidenceBoxId> EvidenceBoxIds { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public OddsPopupStyle OddsPopupStyle { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public List<PlayerReward> PrestigeRewards { get; set; }
        public TemporaryCardCollectionEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        public TemporaryCardCollectionEventInfo()
        {
        }

        public TemporaryCardCollectionEventInfo(TemporaryCardCollectionEventId configKey, string displayName, string description, MetaActivableParams activableParams, string nameLocId, PlayerRequirement unlockRequirement, List<CardCollectionCardSetId> cardSetIds, CardCollectionBalanceId balanceId, List<CardCollectionEvidenceBoxId> evidenceBoxIds, List<PlayerReward> rewards, OddsPopupStyle oddsPopupStyle, List<PlayerReward> prestigeRewards)
        {
        }

        [MetaMember(13, (MetaMemberFlags)0)]
        public int SegmentPriority { get; set; }

        public TemporaryCardCollectionEventInfo(TemporaryCardCollectionEventId configKey, string displayName, string description, MetaActivableParams activableParams, string nameLocId, PlayerRequirement unlockRequirement, List<CardCollectionCardSetId> cardSetIds, CardCollectionBalanceId balanceId, List<CardCollectionEvidenceBoxId> evidenceBoxIds, List<PlayerReward> rewards, OddsPopupStyle oddsPopupStyle, List<PlayerReward> prestigeRewards, int segmentPriority)
        {
        }

        [MetaMember(14, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public TemporaryCardCollectionEventInfo(TemporaryCardCollectionEventId configKey, string displayName, string description, MetaActivableParams activableParams, string nameLocId, PlayerRequirement unlockRequirement, List<CardCollectionCardSetId> cardSetIds, CardCollectionBalanceId balanceId, List<CardCollectionEvidenceBoxId> evidenceBoxIds, List<PlayerReward> rewards, OddsPopupStyle oddsPopupStyle, List<PlayerReward> prestigeRewards, int segmentPriority, EventCategoryInfo categoryInfo)
        {
        }

        public PlayerRequirement Requirement { get; }
    }
}