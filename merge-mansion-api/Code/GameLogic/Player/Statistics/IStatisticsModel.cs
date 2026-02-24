using Metaplay.Core;
using System;
using System.Collections.Generic;
using GameLogic;

namespace Code.GameLogic.Player.Statistics
{
    public interface IStatisticsModel
    {
        MetaTime FirstGameStartTimestamp { get; }

        MetaDuration TotalPlaytimeApprox { get; }

        int BubblesBurstCount { get; }

        Dictionary<int, int> ItemMergeCount { get; }

        Dictionary<Currencies, long> ResourceSpentCount { get; }

        Dictionary<Currencies, long> ResourceGainedCount { get; }

        Dictionary<int, int> ProducerUseCount { get; }

        Dictionary<int, int> ItemsClaimedFromShopCount { get; }

        Dictionary<int, int> ChestsOpenedCount { get; }

        Dictionary<int, int> TaskCompletedCount { get; }
    }
}