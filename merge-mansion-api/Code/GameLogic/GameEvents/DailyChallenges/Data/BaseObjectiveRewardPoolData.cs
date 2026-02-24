using Metaplay.Core.Model;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    [MetaReservedMembers(100, 200)]
    public class BaseObjectiveRewardPoolData
    {
        [MetaMember(101, (MetaMemberFlags)0)]
        private List<List<RewardDefinitionData>> RewardDefinitionsBySlotId { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        protected int RewardSlotsAmount { get; set; }
    }
}