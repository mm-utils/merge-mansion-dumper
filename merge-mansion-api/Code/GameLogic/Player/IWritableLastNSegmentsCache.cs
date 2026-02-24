using System.Collections.Generic;
using System;
using Metaplay.Core.Math;

namespace Code.GameLogic.Player
{
    public interface IWritableLastNSegmentsCache
    {
        int? LastNDaysDay { get; set; }

        IDictionary<int, F64> MedianTransactionsByLastNDays { get; }

        IDictionary<int, int> AverageNumberOfTransactionsByLastNDays { get; }

        IDictionary<int, F64> AverageTransactionValueByLastNDays { get; }

        IDictionary<int, F64> HighestTransactionPriceByLastNDays { get; }

        IDictionary<int, int> TotalTransactionsByLastNDays { get; }
    }
}