using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using GameLogic.Player.Requirements;
using System.Collections.Generic;
using Metaplay.Core;
using Metaplay.Core.Player;
using System.Runtime.Serialization;
using Metaplay.Core.Schedule;
using GameLogic.Config;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents.DailyScoop
{
    [MetaSerializable]
    [MetaActivableConfigData("DailyScoopEvent", false, true)]
    public class DailyScoopEventInfo : ICoreSupportingEventInfo<DailyScoopEventId>, IMetaActivableConfigData<DailyScoopEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<DailyScoopEventId>, IHasGameConfigKey<DailyScoopEventId>, IMetaActivableInfo<DailyScoopEventId>, IHasRequirement, ICoreSupportingEventInfo, IEventSharedInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyScoopEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<DailyScoopWeekId> WeekIds { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<PlayerSegmentId> WeekSegments { get; set; }

        public DailyScoopEventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public MetaRecurringCalendarSchedule Schedule { get; }

        public DailyScoopEventInfo()
        {
        }

        public DailyScoopEventInfo(DailyScoopEventId configKey, string displayName, string description, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, List<DailyScoopWeekId> weekIds, List<MetaRef<PlayerSegmentInfo>> segments, List<PlayerSegmentId> weekSegments)
        {
        }

        [MetaMember(9, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public DailyScoopEventInfo(DailyScoopEventId configKey, string displayName, string description, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, List<DailyScoopWeekId> weekIds, List<MetaRef<PlayerSegmentInfo>> segments, List<PlayerSegmentId> weekSegments, int priority)
        {
        }

        [MetaMember(11, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public DailyScoopEventInfo(DailyScoopEventId configKey, string displayName, string description, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, List<DailyScoopWeekId> weekIds, List<MetaRef<PlayerSegmentInfo>> segments, List<PlayerSegmentId> weekSegments, int priority, EventCategoryInfo categoryInfo)
        {
        }

        public CoreSupportingEventType CoreSupportingEventType { get; }
        public string CoreSupportingEventDisplayName { get; }
        public string CoreSupportingEventConfigKey { get; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}