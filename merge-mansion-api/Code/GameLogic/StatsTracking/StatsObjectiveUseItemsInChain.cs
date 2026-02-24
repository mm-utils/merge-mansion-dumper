using Metaplay.Core.Model;
using GameLogic.StatsTracking;
using GameLogic.Config;
using System.Collections.Generic;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(10)]
    [MetaReservedMembers(201, 300)]
    public class StatsObjectiveUseItemsInChain : ASerializedObjectiveBase
    {
        [MetaMember(201, (MetaMemberFlags)0)]
        private StatsObjectiveUseItems StatsObjectiveItems { get; set; }
        public override StatsObjectiveType ObjectiveType { get; }
        public List<ItemDef> SerialisedItemDefinitions { get; }
    }
}