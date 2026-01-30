using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using System;
using Metaplay.Core;
using GameLogic.Player.Modes;
using GameLogic.Player.Requirements;
using Code.GameLogic.GameEvents;
using System.Collections.Generic;
using Code.GameLogic.Config;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Config.EnergyModeEvent
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4 })]
    [MetaActivableConfigData("EnergyModeEvent", false, true)]
    public class EnergyModeEventInfo : IMetaActivableConfigData<EnergyModeEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<EnergyModeEventId>, IHasGameConfigKey<EnergyModeEventId>, IMetaActivableInfo<EnergyModeEventId>, IEventSharedInfo, IValidatable, IHasRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public EnergyModeEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }
        public EnergyModeEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        public EnergyModeEventInfo()
        {
        }

        public EnergyModeEventInfo(EnergyModeEventId configKey, string displayName, string description, MetaRef<EnergyModeInfo> energyModeRef, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, string nameLocId)
        {
        }

        [MetaMember(8, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public EnergyModeEventInfo(EnergyModeEventId configKey, string displayName, string description, MetaRef<EnergyModeInfo> energyModeRef, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, string nameLocId, EventCategoryInfo categoryInfo)
        {
        }

        [MetaMember(9, (MetaMemberFlags)0)]
        public EnergyModeEnableType EnergyModeEnableType { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public List<MetaRef<EnergyModeInfo>> EnergyModeRefs { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        private string PrefabsOverride { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public string StartPopupDescLocId { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public string EndPopupDescLocId { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public string TaskDescLocId { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public string InfoPopupDescLocId { get; set; }
        public string SharedEventId { get; }

        public EnergyModeEventInfo(EnergyModeEventId configKey, string displayName, string description, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, string nameLocId, EventCategoryInfo categoryInfo, EnergyModeEnableType energyModeEnableType, List<MetaRef<EnergyModeInfo>> energyModeRefs, string prefabsOverride, EventGroupId groupId, int priority, string startPopupDescLocId, string endPopupDescLocId, string taskDescLocId, string infoPopupDescLocId)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }

        PlayerRequirement GameLogic.Player.Requirements.IHasRequirement.Requirement { get; }
    }
}