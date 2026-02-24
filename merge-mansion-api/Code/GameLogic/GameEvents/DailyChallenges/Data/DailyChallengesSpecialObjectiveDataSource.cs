using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic.StatsTracking;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengesSpecialObjectiveDataSource : IConfigItemSource<DailyChallengesSpecialObjectiveData, DailyChallengesSpecialObjectiveId>, IGameConfigSourceItem<DailyChallengesSpecialObjectiveId, DailyChallengesSpecialObjectiveData>, IHasGameConfigKey<DailyChallengesSpecialObjectiveId>
    {
        public DailyChallengesSpecialObjectiveId ConfigKey { get; set; }
        public int ObjectiveGroup { get; set; }
        public List<int> ObjectiveRequirement { get; set; }
        public StatsObjectiveType ObjectiveType { get; set; }
        public List<string> ObjectiveParameter { get; set; }
        public Dictionary<PlayerSegmentId, int> GroupWeightSegment { get; set; }
        private List<string> RewardType { get; set; }
        private List<string> RewardId { get; set; }
        private List<string> RewardAux0 { get; set; }
        private List<string> RewardAux1 { get; set; }
        private List<List<int>> RewardAmount { get; set; }
        private List<string> RequirementType { get; set; }
        private List<string> RequirementId { get; set; }
        private List<string> RequirementAmount { get; set; }
        private List<string> RequirementAux0 { get; set; }
        public string LocId { get; set; }
        private List<List<int>> SlotsRewards { get; set; }
        private List<Dictionary<PlayerSegmentId, int>> SegmentRewardWeight { get; set; }
        private List<int> ForcedCatchUpPointsAmounts { get; set; }
        private List<string> FallbackIds { get; set; }
    }
}