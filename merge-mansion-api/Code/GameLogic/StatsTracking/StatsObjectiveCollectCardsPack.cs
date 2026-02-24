using Metaplay.Core.Model;
using System;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(20)]
    [MetaReservedMembers(201, 300)]
    public class StatsObjectiveCollectCardsPack : ASerializedObjectiveBase
    {
        private static int ANY_STAR_PACK;
        private static int MIN_STAR_PACK;
        private static int MAX_STAR_PACK;
        public sealed override StatsObjectiveType ObjectiveType { get; }
        public bool ShouldCollectAnyStarPack { get; }

        [MetaMember(201, (MetaMemberFlags)0)]
        public int Stars { get; set; }
    }
}