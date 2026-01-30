using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Code.GameLogic.GameEvents;
using Code.GameLogic.Config;
using System;
using GameLogic.Player.Requirements;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;
using System.Runtime.Serialization;
using Metaplay.Core.Schedule;
using GameLogic.StatsTracking;
using Code.GameLogic.IAP;
using Metaplay.Core.Offers;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.ProgressivePacks
{
    [MetaSerializable]
    [MetaActivableConfigData("ProgressionPackEvent", false, true)]
    public class ProgressionPackEventInfo : ICoreSupportingEventInfo<ProgressionPackEventId>, IMetaActivableConfigData<ProgressionPackEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<ProgressionPackEventId>, IHasGameConfigKey<ProgressionPackEventId>, IMetaActivableInfo<ProgressionPackEventId>, IHasRequirement, ICoreSupportingEventInfo, IEventSharedInfo, IValidatable, IOfferPlacementSupporting
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ProgressionPackEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ProgressionPackId ProgressionPackId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public int EventItem { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public MetaRef<InAppProductInfo> PremiumIAP { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public bool UseOfferId { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public MetaRef<MergeMansionOfferGroupInfo> OfferGroupId { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public string PlacementId { get; set; }
        public ProgressionPackEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        [IgnoreDataMember]
        public MetaRecurringCalendarSchedule Schedule { get; }
        public string SharedEventId { get; }
        public int DefaultMaxLevelNumber { get; set; }

        public ProgressionPackEventInfo()
        {
        }

        public ProgressionPackEventInfo(ProgressionPackEventId configKey, ProgressionPackId offerId, StatsObjectiveType objectiveType, string displayName, string description, PlayerRequirement unlockRequirement, List<MetaRef<PlayerSegmentInfo>> segments, int priority, MetaRef<InAppProductInfo> premiumIAP, List<string> objectiveParameter, MetaRef<MergeMansionOfferGroupInfo> offerGroupId, MetaActivableParams activableParams, string placementId)
        {
        }

        [MetaMember(15, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public ProgressionPackEventInfo(ProgressionPackEventId configKey, ProgressionPackId offerId, StatsObjectiveType objectiveType, string displayName, string description, PlayerRequirement unlockRequirement, List<MetaRef<PlayerSegmentInfo>> segments, int priority, MetaRef<InAppProductInfo> premiumIAP, List<string> objectiveParameter, MetaRef<MergeMansionOfferGroupInfo> offerGroupId, MetaActivableParams activableParams, string placementId, EventCategoryInfo categoryInfo)
        {
        }

        public string CoreSupportingEventConfigKey { get; }
        public string CoreSupportingEventDisplayName { get; }
        public CoreSupportingEventType CoreSupportingEventType { get; }
        public OfferPlacementId OfferPlacementId { get; }
        public Option<EventGroupId> GroupIdOption { get; }

        PlayerRequirement GameLogic.Player.Requirements.IHasRequirement.Requirement { get; }
    }
}