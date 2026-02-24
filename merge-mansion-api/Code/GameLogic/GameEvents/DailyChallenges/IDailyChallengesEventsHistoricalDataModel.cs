using Metaplay.Core.Math;
using Code.GameLogic.GameEvents.DailyChallenges.Data;

namespace Code.GameLogic.GameEvents.DailyChallenges
{
    public interface IDailyChallengesEventsHistoricalDataModel
    {
        F64 PreviousWeekCompletionRatio { get; }

        DailyChallengesWeekId PreviousWeekId { get; }
    }
}