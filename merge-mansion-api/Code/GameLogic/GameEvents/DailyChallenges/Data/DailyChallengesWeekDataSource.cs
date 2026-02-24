using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengesWeekDataSource : IConfigItemSource<DailyChallengesWeekData, DailyChallengesWeekId>, IGameConfigSourceItem<DailyChallengesWeekId, DailyChallengesWeekData>, IHasGameConfigKey<DailyChallengesWeekId>
    {
        public DailyChallengesWeekId ConfigKey { get; set; }
        public List<DailyChallengesDayId> DayKeys { get; set; }
        private List<DailyChallengesMilestoneId> MilestoneKeys { get; set; }
        private string WeekDifficulty { get; set; }
    }
}