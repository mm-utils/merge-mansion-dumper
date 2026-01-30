using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using Code.GameLogic.GameEvents;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using GameLogic.Player.Requirements;
using Metaplay.Core.Offers;
using System.Collections.Generic;
using Metaplay.Core;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.MixABooster
{
    [MetaSerializable]
    [MetaActivableConfigData("MixABoosterEvent", false, true)]
    public class MixABoosterEventInfo : ICoreSupportingEventInfo<MixABoosterEventId>, IMetaActivableConfigData<MixABoosterEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<MixABoosterEventId>, IHasGameConfigKey<MixABoosterEventId>, IMetaActivableInfo<MixABoosterEventId>, IHasRequirement, ICoreSupportingEventInfo, IEventSharedInfo, IValidatable, IOfferPlacementSupporting
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MixABoosterEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public OfferPlacementId PlacementId { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        private List<MetaRef<MixABoosterRecipe>> RecipeRefs { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public Dictionary<MixABoosterIngredientId, int> InitialIngredients { get; set; }
        public MixABoosterEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public IEnumerable<MixABoosterRecipe> Recipes { get; }
        public string CoreSupportingEventDisplayName { get; }
        public string CoreSupportingEventConfigKey { get; }
        public CoreSupportingEventType CoreSupportingEventType { get; }

        public MixABoosterEventInfo()
        {
        }

        public MixABoosterEventInfo(MixABoosterEventId configKey, MetaActivableParams activableParams, string displayName, string description, PlayerRequirement unlockRequirement, OfferPlacementId placementId, List<MetaRef<MixABoosterRecipe>> recipeRefs, Dictionary<MixABoosterIngredientId, int> initialIngredients)
        {
        }

        [MetaMember(9, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }
        public int Priority { get; }
        public string SharedEventId { get; }

        public MixABoosterEventInfo(MixABoosterEventId configKey, MetaActivableParams activableParams, string displayName, string description, PlayerRequirement unlockRequirement, OfferPlacementId placementId, List<MetaRef<MixABoosterRecipe>> recipeRefs, Dictionary<MixABoosterIngredientId, int> initialIngredients, EventCategoryInfo categoryInfo)
        {
        }

        public OfferPlacementId OfferPlacementId { get; }
        public Option<EventGroupId> GroupIdOption { get; }

        PlayerRequirement GameLogic.Player.Requirements.IHasRequirement.Requirement { get; }
    }
}