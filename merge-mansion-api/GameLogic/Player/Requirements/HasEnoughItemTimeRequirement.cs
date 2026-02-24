using Metaplay.Core.Model;
using Code.GameLogic.Config;
using Metaplay.Core;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(65)]
    public class HasEnoughItemTimeRequirement : PlayerRequirement, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration RequiredTime { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MergeItemFilterComponent FilterComponent { get; set; }
    }
}