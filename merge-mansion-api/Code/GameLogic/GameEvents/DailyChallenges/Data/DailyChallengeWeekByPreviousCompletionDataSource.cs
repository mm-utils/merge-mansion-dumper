using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengeWeekByPreviousCompletionDataSource : IConfigItemSource<DailyChallengeWeekByPreviousCompletionData, DailyChallengesWeekId>, IGameConfigSourceItem<DailyChallengesWeekId, DailyChallengeWeekByPreviousCompletionData>, IHasGameConfigKey<DailyChallengesWeekId>
    {
        public DailyChallengesWeekId ConfigKey { get; set; }
        private List<float> PointsEarnedRatios { get; set; }
        private List<DailyChallengesWeekId> NewWeeksIds { get; set; }
    }
}