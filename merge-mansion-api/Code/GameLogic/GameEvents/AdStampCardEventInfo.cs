using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using System;
using GameLogic.Player.Requirements;
using GameLogic.Story;
using Metaplay.Core.Offers;
using System.Runtime.Serialization;
using Metaplay.Core.Schedule;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("AdStampCardEvent", false, true)]
    public class AdStampCardEventInfo : ICoreSupportingEventInfo<AdStampCardEventId>, IMetaActivableConfigData<AdStampCardEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<AdStampCardEventId>, IHasGameConfigKey<AdStampCardEventId>, IMetaActivableInfo<AdStampCardEventId>, IHasRequirement, ICoreSupportingEventInfo, IEventSharedInfo, IOfferPlacementSupporting
    {
        [MetaMember(5, (MetaMemberFlags)0)]
        public List<PlayerReward> DailyRewards;
        [MetaMember(1, (MetaMemberFlags)0)]
        public AdStampCardEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<int> RequiredAdWatchedPerDay { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<int> UnlockPeriods { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<PlayerReward> FinalRewards { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public StoryDefinitionId StoryDefinition { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public int FreeInitialStamps { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public OfferPlacementId PlacementId { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        [IgnoreDataMember]
        public AdStampCardEventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public MetaRecurringCalendarSchedule Schedule { get; }
        public string SharedEventId { get; }
        public string CoreSupportingEventConfigKey { get; }
        public string CoreSupportingEventDisplayName { get; }
        public CoreSupportingEventType CoreSupportingEventType { get; }

        public AdStampCardEventInfo()
        {
        }

        public AdStampCardEventInfo(AdStampCardEventId configKey, string displayName, string description, List<int> requiredAdWatchedPerDay, List<int> unlockPeriods, List<PlayerReward> dailyRewards, List<PlayerReward> finalRewards, MetaActivableParams activableParams, EventGroupId groupId, int priority, PlayerRequirement unlockRequirement, StoryDefinitionId storyDefinition, int freeInitialStamps, OfferPlacementId offerPlacementId, EventCategoryInfo categoryInfo)
        {
        }

        public OfferPlacementId OfferPlacementId { get; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}