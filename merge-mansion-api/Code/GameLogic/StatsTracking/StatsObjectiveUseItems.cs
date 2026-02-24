using Metaplay.Core.Model;
using GameLogic.Config;
using System.Collections.Generic;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(9)]
    [MetaReservedMembers(201, 300)]
    public class StatsObjectiveUseItems : ASerializedObjectiveBase
    {
        [MetaMember(201, (MetaMemberFlags)0)]
        public List<ItemDef> SerialisedItemDefinitions { get; set; }
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}