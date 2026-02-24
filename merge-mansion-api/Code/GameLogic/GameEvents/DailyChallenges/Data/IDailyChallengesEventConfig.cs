using System.Collections.Generic;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public interface IDailyChallengesEventConfig
    {
        Dictionary<DailyChallengesWeekId, DailyChallengesWeekData> DailyChallengesWeeks { get; }

        Dictionary<DailyChallengesDayId, DailyChallengesDayData> DailyChallengesDays { get; }

        Dictionary<DailyChallengesMinigameId, DailyChallengesWeekByMinigameIdData> DailyChallengesWeekByMinigameId { get; }

        Dictionary<DailyChallengesWeekId, DailyChallengeWeekByPreviousCompletionData> DailyChallengesWeekByPreviousCompletion { get; }

        Dictionary<DailyChallengesMinigameId, DailyChallengesMinigameData> DailyChallengesMinigames { get; }

        Dictionary<DailyChallengesStandardObjectiveId, DailyChallengesStandardObjectiveData> DailyChallengesStandardObjectives { get; }

        Dictionary<DailyChallengesSpecialObjectiveId, DailyChallengesSpecialObjectiveData> DailyChallengesSpecialObjectives { get; }

        Dictionary<DailyChallengesMilestoneId, DailyChallengesMilestoneData> DailyChallengesMilestones { get; }

        IDailyChallengesEventSettings DailyChallengesEventSettings { get; }
    }
}