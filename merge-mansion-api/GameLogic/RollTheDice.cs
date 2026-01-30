using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;
using System.Collections.Generic;

namespace GameLogic
{
    [MetaSerializableDerived(4)]
    public class RollTheDice : ICoreSupportEventMinigameModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId MinigameId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ServerDiceRollResult LastDiceRollResult { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public RollTheDiceLevelId CurrentLevelId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public RollTheDiceLevelInfo CurrentLevelInfo { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public Dictionary<string, int> CollectedIngredients { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public RollTheDiceMultiplierId ActiveMultiplierConfigId { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int ActiveMultiplierIndex { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public int ActiveMultiplierValue { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public long SnapshotTokenBalance { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public int MaxUnlockedMultiplierIndex { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public int StepsCount { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public int AttemptIndex { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public List<int> InitialSequenceFaceIndices { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public bool IsCurrentLevelCompleted { get; set; }
    }
}