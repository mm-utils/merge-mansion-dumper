using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;
using GameLogic.Player.Board;
using System.Collections.Generic;
using GameLogic.Player.Items;
using System.Runtime.Serialization;
using GameLogic.Player.Rewards;
using Metaplay.Core;
using GameLogic.Player.DynamicEvents;
using Metaplay.Core.Offers;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(2)]
    [MetaBlockedMembers(new int[] { 6, 8, 10, 16, 20 })]
    public class BoardEventModel : ExtendableEventState<EventId, BoardEventInfo>, IBoardEventModel, IEventGroupModel<BoardEventInfo>, IPointsEvent, IGroupIdGetter
    {
        [MetaMember(2, (MetaMemberFlags)0)]
        public int Level;
        [MetaMember(3, (MetaMemberFlags)0)]
        public int Points;
        [MetaMember(7, (MetaMemberFlags)0)]
        public int CompletedTaskCount;
        [MetaMember(11, (MetaMemberFlags)0)]
        public int LastSeenPoints;
        [MetaMember(12, (MetaMemberFlags)0)]
        public int LastSeenLevel;
        [MetaMember(13, (MetaMemberFlags)0)]
        public bool IsEventSeen;
        [MetaMember(14, (MetaMemberFlags)0)]
        public bool IsPlayable;
        [MetaMember(17, (MetaMemberFlags)0)]
        public int ConsumedLevel;
        [MetaMember(18, (MetaMemberFlags)0)]
        public bool NotedPhasePreview;
        [MetaMember(19, (MetaMemberFlags)0)]
        public bool NotedPhaseActive;
        [MetaMember(21, (MetaMemberFlags)0)]
        public bool CanBeResolved;
        [MetaMember(22, (MetaMemberFlags)0)]
        public bool RequestExtension;
        [MetaMember(23, (MetaMemberFlags)0)]
        public int EnterMergeBoardCount;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override EventId ActivableId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MergeBoard MergeBoard { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<int> PocketItems_DEPRECATED { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public List<IBoardItem> PocketItems { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public EventOfferModel EventOfferModel { get; set; }

        [IgnoreDataMember]
        public BoardEventInfo Info { get; }

        [MetaMember(15, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("WorkaroundMetaMember15")]
        public List<EventTaskId> AvailableTaskIds { get; set; }

        [MetaMember(25, (MetaMemberFlags)0)]
        public bool PortalItemGiven { get; set; }

        [IgnoreDataMember]
        bool Code.GameLogic.GameEvents.IBoardEventModel.EnterBoardDialogueTriggered { get; set; }

        [IgnoreDataMember]
        int Code.GameLogic.GameEvents.IBoardEventModel.EnterMergeBoardCount { get; set; }

        [IgnoreDataMember]
        MetaActivableState.Activation? Code.GameLogic.GameEvents.IBoardEventModel.LatestActivation { get; }

        [IgnoreDataMember]
        bool Code.GameLogic.GameEvents.IBoardEventModel.RequestExtension { get; set; }

        [IgnoreDataMember]
        public override ExtendableEventParams ExtendableEventParams { get; }

        private BoardEventModel()
        {
        }

        public BoardEventModel(BoardEventInfo info)
        {
        }

        [MetaMember(26, (MetaMemberFlags)0)]
        public bool Resolved { get; set; }
        public IStringId Id { get; }

        [MetaMember(27, (MetaMemberFlags)0)]
        public List<DynamicEventTaskState> DynamicEventTasks { get; set; }

        [IgnoreDataMember]
        OfferPlacementId Code.GameLogic.GameEvents.IBoardEventModel.BoardShopPlacementId { get; }

        [IgnoreDataMember]
        OfferPlacementId Code.GameLogic.GameEvents.IBoardEventModel.BoardShopFlashPlacementId { get; }

        [IgnoreDataMember]
        public IBoardEventInfo BoardEventInfo { get; }

        [IgnoreDataMember]
        public int SelectedPortalItem { get; }
    }
}