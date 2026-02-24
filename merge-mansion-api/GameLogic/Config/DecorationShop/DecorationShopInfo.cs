using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Player.Requirements;
using Code.GameLogic.GameEvents;
using Code.GameLogic.Config;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Config.DecorationShop
{
    [MetaSerializable]
    [MetaActivableConfigData("DecorationShop", false, true)]
    public class DecorationShopInfo : IMetaActivableConfigData<DecorationShopId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<DecorationShopId>, IHasGameConfigKey<DecorationShopId>, IMetaActivableInfo<DecorationShopId>, IEventSharedInfo, IValidatable, IHasRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DecorationShopId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string NameLocId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<MetaRef<DecorationShopSetInfo>> SetRefs { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        public DecorationShopId ActivableId => ConfigKey;
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }

        public DecorationShopInfo()
        {
        }

        public DecorationShopInfo(DecorationShopId configKey, string displayName, string description, string nameLocId, List<MetaRef<DecorationShopSetInfo>> setRefs, MetaActivableParams activableParams, PlayerRequirement unlockRequirement)
        {
        }

        [MetaMember(8, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public int Priority { get; set; }
        public string SharedEventId { get; }

        public DecorationShopInfo(DecorationShopId configKey, string displayName, string description, string nameLocId, List<MetaRef<DecorationShopSetInfo>> setRefs, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, int priority)
        {
        }

        [MetaMember(10, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public DecorationShopInfo(DecorationShopId configKey, string displayName, string description, string nameLocId, List<MetaRef<DecorationShopSetInfo>> setRefs, MetaActivableParams activableParams, PlayerRequirement unlockRequirement, int priority, EventCategoryInfo categoryInfo)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }

        PlayerRequirement GameLogic.Player.Requirements.IHasRequirement.Requirement { get; }
    }
}