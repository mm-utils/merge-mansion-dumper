using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1076)]
    public class PlayerTotalTransactionsLastNDays : TypedPlayerPropertyId<int>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int Days { get; set; }
        public override string DisplayName { get; }
    }
}