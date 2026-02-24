using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using System.Collections.Generic;
using GameLogic.Player.Requirements;
using Code.GameLogic.GameEvents;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.MiniEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("MiniEvent", false, true)]
    public class MiniEventInfo : IMetaActivableConfigData<MiniEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<MiniEventId>, IHasGameConfigKey<MiniEventId>, IMetaActivableInfo<MiniEventId>, IValidatable, IEventSharedInfo, IHasRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MiniEventId MiniEventId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DescLocId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public Dictionary<MiniEventTypeId, MiniEventValues<string>> NewValuesLookup { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        private PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public MiniEventUIId UISchemeId { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public bool ShowStartPopup { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public bool ShowMainHubBadge { get; set; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public MiniEventId ConfigKey => MiniEventId;
        public MiniEventId ActivableId => ConfigKey;

        public MiniEventInfo()
        {
        }

        public MiniEventInfo(MiniEventId id, string nameLocId, string descLocId, string displayName, string description, MetaActivableParams activableParams, Dictionary<MiniEventTypeId, MiniEventValues<string>> newValuesLookup, PlayerRequirement unlockRequirement, MiniEventUIId uiSchemeId, bool showStartPopup, bool showMainHubBadge)
        {
        }

        [MetaMember(12, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public MiniEventInfo(MiniEventId id, string nameLocId, string descLocId, string displayName, string description, MetaActivableParams activableParams, Dictionary<MiniEventTypeId, MiniEventValues<string>> newValuesLookup, PlayerRequirement unlockRequirement, MiniEventUIId uiSchemeId, bool showStartPopup, bool showMainHubBadge, int priority)
        {
        }

        [MetaMember(14, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public MiniEventInfo(MiniEventId id, string nameLocId, string descLocId, string displayName, string description, MetaActivableParams activableParams, Dictionary<MiniEventTypeId, MiniEventValues<string>> newValuesLookup, PlayerRequirement unlockRequirement, MiniEventUIId uiSchemeId, bool showStartPopup, bool showMainHubBadge, int priority, EventCategoryInfo categoryInfo)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }

        PlayerRequirement GameLogic.Player.Requirements.IHasRequirement.Requirement { get; }
    }
}