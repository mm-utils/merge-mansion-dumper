using Code.GameLogic.GameEvents.DailyChallenges.Data;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents.DailyChallenges
{
    public interface IDailyChallengesMinigameModel : ICoreSupportEventMinigameModel
    {
        DailyChallengesMinigameId MinigameId { get; }

        DailyChallengesWeekId EventWeekId { get; }

        DailyChallengesDayId CurrentDayId { get; }

        CoreSupportEventId EventId { get; }

        float DailyProgress { get; }

        float WeeklyProgress { get; }

        bool DailyRewardClaimed { get; }

        List<DailyChallengesObjectiveModel> CurrentStandardTasks { get; }

        List<DailyChallengesObjectiveModel> CurrentSpecialTasks { get; }

        List<DailyChallengesMilestoneModel> Milestones { get; }

        int CompletedStandardObjectivesCount { get; }
    }
}