using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengesMilestoneDataSource : IConfigItemSource<DailyChallengesMilestoneData, DailyChallengesMilestoneId>, IGameConfigSourceItem<DailyChallengesMilestoneId, DailyChallengesMilestoneData>, IHasGameConfigKey<DailyChallengesMilestoneId>
    {
        public DailyChallengesMilestoneId ConfigKey { get; set; }
        public int RequiredPoints { get; set; }
        private List<string> RewardSegment { get; set; }
        private List<string> RewardType { get; set; }
        private List<string> RewardId { get; set; }
        private List<string> RewardAux0 { get; set; }
        private List<string> RewardAux1 { get; set; }
        private List<int> RewardAmount { get; set; }
    }
}