using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;
using GameLogic.Player.Board;
using System.Collections.Generic;
using GameLogic.Player.Items;
using Metaplay.Core;
using System.Runtime.Serialization;
using GameLogic.Player.Rewards;
using Metaplay.Core.Offers;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(9)]
    public class LeaderboardEventModel : MetaActivableState<LeaderboardEventId, LeaderboardEventInfo>, IBoardEventModel, IPointsEvent, IGroupIdGetter
    {
        private static byte InitialBoolFields;
        private static int InitialScore;
        public static int InitialLevel;
        private static int InitialLevelProgress;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override LeaderboardEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public MergeBoard MergeBoard { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public List<IBoardItem> PocketItems { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        protected byte BoolFields { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public int Score { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int Level { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public int LevelProgress { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public EntityId DivisionId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<int> ClaimedLevels { get; set; }

        [IgnoreDataMember]
        public int EnterMergeBoardCount { get; set; }
        public bool PortalItemGiven { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }
        public bool EnterBoardDialogueTriggered { get; set; }
        public bool RankingRewardsClaimed { get; set; }
        public bool EndDialogueTriggered { get; set; }

        [IgnoreDataMember]
        int Code.GameLogic.GameEvents.IBoardEventModel.EnterMergeBoardCount { get; set; }

        [IgnoreDataMember]
        MetaActivableState.Activation? Code.GameLogic.GameEvents.IBoardEventModel.LatestActivation { get; }

        [IgnoreDataMember]
        bool Code.GameLogic.GameEvents.IBoardEventModel.RequestExtension { get; set; }

        public LeaderboardEventModel()
        {
        }

        public LeaderboardEventModel(LeaderboardEventInfo info)
        {
        }

        [IgnoreDataMember]
        public bool Joined { get; }

        [IgnoreDataMember]
        public LeaderboardEventInfo Info { get; }
        public IStringId Id { get; }

        [IgnoreDataMember]
        OfferPlacementId Code.GameLogic.GameEvents.IBoardEventModel.BoardShopPlacementId { get; }

        [IgnoreDataMember]
        OfferPlacementId Code.GameLogic.GameEvents.IBoardEventModel.BoardShopFlashPlacementId { get; }

        [IgnoreDataMember]
        IBoardEventInfo Code.GameLogic.GameEvents.IBoardEventModel.BoardEventInfo { get; }

        [IgnoreDataMember]
        public int SelectedPortalItem { get; }
    }
}