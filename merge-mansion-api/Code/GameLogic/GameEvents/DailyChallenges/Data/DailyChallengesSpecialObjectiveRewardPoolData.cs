using Metaplay.Core.Model;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesSpecialObjectiveRewardPoolData : BaseObjectiveRewardPoolData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private List<int> ForcedCatchUpPointsAmounts { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private DailyChallengesSpecialObjectiveId SpecialObjectiveId { get; set; }
        private bool IsCatchUpPointsRewardAvailable { get; }
    }
}