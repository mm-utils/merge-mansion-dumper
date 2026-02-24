using System.Collections.Generic;
using GameLogic.Config.Costs;
using GameLogic.Player.Rewards;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Metaplay.Core.Model;
using Code.GameLogic.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 7, 8 })]
    public class EventOfferInfo : IMetaActivableConfigData<EventOfferId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<EventOfferId>, IHasGameConfigKey<EventOfferId>, IMetaActivableInfo<EventOfferId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public EventOfferId EventOfferId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public ICost Cost { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<PlayerReward> Rewards { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }
        public EventOfferId ConfigKey => EventOfferId;
        public EventOfferId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        public EventOfferInfo()
        {
        }

        public EventOfferInfo(EventOfferId eventOfferId, string displayName, string description, ICost cost, List<PlayerReward> rewards, MetaActivableParams activableParams)
        {
        }
    }
}