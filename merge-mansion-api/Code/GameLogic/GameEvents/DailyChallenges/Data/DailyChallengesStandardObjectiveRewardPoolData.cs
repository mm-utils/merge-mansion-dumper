using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesStandardObjectiveRewardPoolData : BaseObjectiveRewardPoolData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private DailyChallengesStandardObjectiveId StandardObjectiveId { get; set; }
    }
}