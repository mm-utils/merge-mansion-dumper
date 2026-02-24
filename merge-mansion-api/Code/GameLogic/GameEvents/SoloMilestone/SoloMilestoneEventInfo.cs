using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using System;
using GameLogic.Player.Requirements;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Code.GameLogic.Config;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents.SoloMilestone
{
    [MetaSerializable]
    [MetaActivableConfigData("SoloMilestoneEvent", false, true)]
    public class SoloMilestoneEventInfo : ICoreSupportingEventInfo<SoloMilestoneEventId>, IMetaActivableConfigData<SoloMilestoneEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<SoloMilestoneEventId>, IHasGameConfigKey<SoloMilestoneEventId>, IMetaActivableInfo<SoloMilestoneEventId>, IHasRequirement, ICoreSupportingEventInfo, IEventSharedInfo, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public SoloMilestoneEventId ConfigKey { get; set; }

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
        public List<SoloMilestoneMilestonesId> Milestones { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public bool TokenSpawnsEnabled { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public string Theme { get; set; }

        public SoloMilestoneEventId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        public SoloMilestoneEventInfo()
        {
        }

        public SoloMilestoneEventInfo(SoloMilestoneEventId configKey, string displayName, string description, MetaActivableParams activableParams, string nameLocId, PlayerRequirement unlockRequirement, List<SoloMilestoneMilestonesId> milestones, bool tokenSpawnsEnabled, string theme)
        {
        }

        [MetaMember(10, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public SoloMilestoneEventInfo(SoloMilestoneEventId configKey, string displayName, string description, MetaActivableParams activableParams, string nameLocId, PlayerRequirement unlockRequirement, List<SoloMilestoneMilestonesId> milestones, bool tokenSpawnsEnabled, string theme, int priority)
        {
        }

        [MetaMember(12, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public SoloMilestoneEventInfo(SoloMilestoneEventId configKey, string displayName, string description, MetaActivableParams activableParams, string nameLocId, PlayerRequirement unlockRequirement, List<SoloMilestoneMilestonesId> milestones, bool tokenSpawnsEnabled, string theme, int priority, EventCategoryInfo categoryInfo)
        {
        }

        public string CoreSupportingEventDisplayName { get; }
        public string CoreSupportingEventConfigKey { get; }
        public CoreSupportingEventType CoreSupportingEventType { get; }
        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}