using Metaplay.Core.Model;
using GameLogic.Player.Requirements;
using System;

namespace Code.GameLogic.Player.Requirements
{
    [MetaSerializableDerived(69)]
    public class HasUncompletedAreasRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int _requirementAmount;
    }
}