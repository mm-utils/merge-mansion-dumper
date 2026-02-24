using Metaplay.Core.Model;
using GameLogic.Player.Requirements;
using System;

namespace Code.GameLogic.Player.Requirements
{
    [MetaSerializableDerived(70)]
    public class RollTheDiceLevelsRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int _requirementAmount;
    }
}