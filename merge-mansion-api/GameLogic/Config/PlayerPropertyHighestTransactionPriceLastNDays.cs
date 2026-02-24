using Metaplay.Core.Model;
using Metaplay.Core.Player;
using Metaplay.Core.Math;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1016)]
    public class PlayerPropertyHighestTransactionPriceLastNDays : TypedPlayerPropertyId<F64>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int Days { get; set; }
        public override string DisplayName { get; }
    }
}