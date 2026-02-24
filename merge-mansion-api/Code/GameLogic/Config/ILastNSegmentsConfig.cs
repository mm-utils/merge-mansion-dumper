using System.Collections.Generic;
using System;

namespace Code.GameLogic.Config
{
    public interface ILastNSegmentsConfig
    {
        List<int> ModeLastNTransactionsSegments { get; }

        List<int> MedianTransactionLastNDaysSegments { get; }

        List<int> AverageNumberOfTransactionsInNDaysSegments { get; }

        List<int> AverageTransactionValueInNDaysSegments { get; }

        List<int> HighestTransactionValueInDaysSegments { get; }

        List<int> TotalTransactionsDaysSegments { get; }
    }
}