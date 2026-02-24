using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengesDayDataSource : IConfigItemSource<DailyChallengesDayData, DailyChallengesDayId>, IGameConfigSourceItem<DailyChallengesDayId, DailyChallengesDayData>, IHasGameConfigKey<DailyChallengesDayId>
    {
        public DailyChallengesDayId ConfigKey { get; set; }
        public List<int> MinObjectivesPerGroup { get; set; }
        public List<int> SpecialObjectiveGroups { get; set; }
        public List<DailyChallengesStandardObjectiveId> StandardObjectives { get; set; }
        private List<string> RewardSegment { get; set; }
        private List<string> RewardType { get; set; }
        private List<string> RewardId { get; set; }
        private List<string> RewardAux0 { get; set; }
        private List<string> RewardAux1 { get; set; }
        private List<int> RewardAmount { get; set; }
        private int TargetMilestone { get; set; }
        private int RequiredTaskAmountForDailyCompletion { get; set; }
    }
}