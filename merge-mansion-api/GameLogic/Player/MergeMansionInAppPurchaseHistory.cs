using Metaplay.Core.Model;
using Metaplay.Core.InAppPurchase;
using System;
using Metaplay.Core.Math;
using System.Collections.Generic;

namespace GameLogic.Player
{
    [MetaSerializableDerived(1)]
    public class MergeMansionInAppPurchaseHistory : InAppPurchaseHistory
    {
        public static int MaxNumberOfDays;
        public static int MaxModeWindowLength;
        protected override int RecentPurchasesMaxDays { get; }
        public override int TotalNumPurchases { get; }
        public override F64 TotalSpend { get; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public Dictionary<int, F64> ModesPerNumberOfPurchases { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int TotalWebshopPurchaseCount { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public F64 TotalWebshopPurchaseSpend { get; set; }

        [MetaMember(1, (MetaMemberFlags)0)]
        public List<InAppPurchaseHistory.RecentPurchaseEvent> RecentPurchasesNoSeasonPass { get; set; }
    }
}