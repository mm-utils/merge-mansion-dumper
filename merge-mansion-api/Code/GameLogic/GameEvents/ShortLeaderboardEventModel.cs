using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using GameLogic.Player.Rewards;
using System;
using Metaplay.Core;
using System.Collections.Generic;
using GameLogic.Player.Board;
using GameLogic.Player.Items;
using Metaplay.Core.Offers;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(19)]
    public class ShortLeaderboardEventModel : MetaActivableState<ShortLeaderboardEventId, ShortLeaderboardEventInfo>, IBoardEventModel, IGroupIdGetter, IPointsEvent
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override ShortLeaderboardEventId ActivableId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private byte BoolFields { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaTime StartTime { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public ShortLeaderboardEventModel.StageData CurrentStage { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private List<ShortLeaderboardEventModel.StageData> OtherStages { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public MergeBoard IntroMergeBoard { get; set; }
        public bool StartNoted { get; set; }
        public bool EndNoted { get; set; }
        public bool EndDialogueTriggered { get; set; }
        public bool FinalRewardClaimed { get; set; }
        public bool InfoPopupTriggered { get; set; }
        public bool IntroFinished { get; set; }
        public bool RequestExtension { get; set; }
        public IBoardEventInfo BoardEventInfo { get; }
        public List<IBoardItem> PocketItems { get; }
        public MergeBoard MergeBoard { get; }
        public int EnterMergeBoardCount { get; set; }
        public bool EnterBoardDialogueTriggered { get; set; }
        public OfferPlacementId BoardShopPlacementId { get; }
        public OfferPlacementId BoardShopFlashPlacementId { get; }
        public bool PortalItemGiven { get; }
        public IStringId Id { get; }

        public ShortLeaderboardEventModel()
        {
        }

        public ShortLeaderboardEventModel(ShortLeaderboardEventInfo info)
        {
        }

        [MetaSerializable]
        public struct StageData
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public ShortLeaderboardEventStageId StageId;
            [MetaMember(2, (MetaMemberFlags)0)]
            public PlayerShortLeaderboardEventStageState State;
        }

        public int SelectedPortalItem { get; }
    }
}