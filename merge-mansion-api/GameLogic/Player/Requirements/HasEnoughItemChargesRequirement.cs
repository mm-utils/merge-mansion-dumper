using Metaplay.Core.Model;
using Code.GameLogic.Config;
using System;

namespace GameLogic.Player.Requirements
{
    [MetaSerializableDerived(64)]
    public class HasEnoughItemChargesRequirement : PlayerRequirement, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int RequiredCharges { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MergeItemFilterComponent FilterComponent { get; set; }
    }
}