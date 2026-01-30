using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;
using System.Collections.Generic;
using GameLogic.CardCollection;
using GameLogic.Random.ControlledRandom;
using System.Runtime.Serialization;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(18)]
    [MetaBlockedMembers(new int[] { 11 })]
    public class TemporaryCardCollectionEventModel : MetaActivableState<TemporaryCardCollectionEventId, TemporaryCardCollectionEventInfo>
    {
        private static byte InitialBoolFields;
        [MetaMember(13, (MetaMemberFlags)0)]
        private Dictionary<CardCollectionCardId, int> duplicateCounts;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override TemporaryCardCollectionEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private byte BoolFields { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public HashSet<CardCollectionCardId> OwnedCardIds { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public Dictionary<CardCollectionPackActivationId, int> InitialSequenceIndexByPackActivationId { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public Dictionary<string, ControlledRandomMinMaxSequence> ControlledRandomMinMaxSequences { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public Dictionary<CardHiddenRarity, List<CardCollectionCardId>> ChosenCardsIdsByHiddenRarity { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string AlgorithmLogContent { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [Obsolete("Keeping for migration, can be removed in summer 2026")]
        private Queue<CardCollectionCardId> UnusedInformantTips { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        private HashSet<CardCollectionCardSetId> ClaimedRewardsCardSetIds { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public EvidenceRoomState EvidenceRoomState { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public bool ClaimedRewards { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public int PrestigeLevel { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public int LastPrestigeLevelNoted { get; set; }

        [IgnoreDataMember]
        public TemporaryCardCollectionEventInfo Info { get; }
        public bool PreviewNoted { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }

        private TemporaryCardCollectionEventModel()
        {
        }

        public TemporaryCardCollectionEventModel(TemporaryCardCollectionEventInfo info)
        {
        }

        [MetaSerializable]
        public class DuplicateRewardPair
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            private int regular;
            [MetaMember(2, (MetaMemberFlags)0)]
            private int special;
            public DuplicateRewardPair()
            {
            }

            public DuplicateRewardPair(CardCollectionDuplicateRewardInfo duplicateRewardInfo)
            {
            }
        }

        public bool InfoNoted { get; set; }
    }
}