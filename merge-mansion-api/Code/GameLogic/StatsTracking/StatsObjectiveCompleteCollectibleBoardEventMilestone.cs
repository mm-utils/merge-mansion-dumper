using Metaplay.Core.Model;
using System.Text.RegularExpressions;
using GameLogic.StatsTracking;
using System;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(18)]
    [MetaReservedMembers(201, 300)]
    public class StatsObjectiveCompleteCollectibleBoardEventMilestone : ASerializedObjectiveBase
    {
        private Regex _cachedRegex;
        public sealed override StatsObjectiveType ObjectiveType { get; }

        [MetaMember(201, (MetaMemberFlags)0)]
        public string CollectibleBoardEventIdFormat { get; set; }
    }
}