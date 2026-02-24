using Metaplay.Core.Model;
using GameLogic.Player.Requirements;
using Metaplay.Core;
using System;

namespace Code.GameLogic.Player.Requirements.Activables
{
    [MetaSerializableDerived(66)]
    public class HasActivableKindActiveForDurationRequirement : PlayerRequirement
    {
        private MetaDuration _courtesyDuration;
        [MetaMember(1, (MetaMemberFlags)0)]
        private long DurationInMilliseconds { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private string ActivableKind { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private string RegexPattern { get; set; }
    }
}