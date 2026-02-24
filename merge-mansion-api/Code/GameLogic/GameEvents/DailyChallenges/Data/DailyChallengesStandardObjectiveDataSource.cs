using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using GameLogic.StatsTracking;
using System.Collections.Generic;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengesStandardObjectiveDataSource : IConfigItemSource<DailyChallengesStandardObjectiveData, DailyChallengesStandardObjectiveId>, IGameConfigSourceItem<DailyChallengesStandardObjectiveId, DailyChallengesStandardObjectiveData>, IHasGameConfigKey<DailyChallengesStandardObjectiveId>
    {
        public DailyChallengesStandardObjectiveId ConfigKey { get; set; }
        public int ObjectiveRequirement { get; set; }
        public StatsObjectiveType ObjectiveType { get; set; }
        public List<string> ObjectiveParameter { get; set; }
        public int OrderPriority { get; set; }
        private List<string> RewardType { get; set; }
        private List<string> RewardId { get; set; }
        private List<string> RewardAux0 { get; set; }
        private List<string> RewardAux1 { get; set; }
        private List<int> RewardAmount { get; set; }
        private List<List<int>> SlotsRewards { get; set; }
        private List<Dictionary<PlayerSegmentId, int>> SegmentRewardWeight { get; set; }
        private List<string> RequirementType { get; set; }
        private List<string> RequirementId { get; set; }
        private List<string> RequirementAmount { get; set; }
        private List<string> RequirementAux0 { get; set; }
        private List<string> FallbackIds { get; set; }
        private string LocId { get; set; }
    }
}