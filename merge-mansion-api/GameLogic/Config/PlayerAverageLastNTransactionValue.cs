using Metaplay.Core.Model;
using Metaplay.Core.Player;
using Metaplay.Core.Math;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1075)]
    public class PlayerAverageLastNTransactionValue : TypedPlayerPropertyId<F64>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private int Transactions { get; set; }
        public override string DisplayName { get; }
    }
}