using System;
using System.Collections.Generic;
using GameLogic.Merge;
using GameLogic.Player.Items;
using Metaplay.Core;
using Metaplay.Core.Math;
using System.Runtime.Serialization;
using Metaplay.Core.Model;
using GameLogic.Player.Board.Placement;
using Merge;
using GameLogic.Random;
using System.Reflection;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using Code.GameLogic.Player.Board;

namespace GameLogic.Player.Board
{
    [DefaultMember("Item")]
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4 })]
    public class MergeBoard : IBoard, IBoardQuery
    {
        [IgnoreDataMember]
        public ValueTuple<int, int> BoardDimensions { get; }

        [JsonProperty("boardId")]
        [MetaMember(7, (MetaMemberFlags)0)]
        public MergeBoardId BoardIdentifier { get; }

        [IgnoreDataMember]
        public IEnumerable<MergeItem> MergeItems { get; }

        [IgnoreDataMember]
        public IEnumerable<Coordinate> Coordinates { get; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public BoardBubbleState BubbleState { get; }

        public MergeItem GetItem(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public bool IsValid(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty(Coordinate coordinate)
        {
            throw new NotImplementedException();
        }

        private SortedDictionary<MetaTime, ValueTuple<ItemActionType, MergeItem, Coordinate>> timeResolveDictionary;
        private Dictionary<Coordinate, F32> boostOfCoordinate;
        [IgnoreDataMember]
        private ICollection<Coordinate> coordinates;
        [MetaMember(1, (MetaMemberFlags)0)]
        private List<MergeItem> BoardItems { get; set; }

        [IgnoreDataMember]
        public MetaTime BoardCreationTime { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaTime LastModificationTime { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private int Width { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        private int Height { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public bool HasEnded { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public long MergeCount { get; set; }

        [IgnoreDataMember]
        public List<MergeItem> MergeItemsNonAlloc { get; }

        [IgnoreDataMember]
        public IPlacement DefaultPlacement { get; }

        [IgnoreDataMember]
        public MergeItem Item { get; set; }

        [IgnoreDataMember]
        public IEnumerable<ValueTuple<Coordinate, MergeItem>> Items { get; }

        public MergeBoard()
        {
        }

        public MergeBoard(MergeBoardId identifier, int boardWidth, int boardHeight, MetaTime creationTime)
        {
        }

        public MergeBoard(IPlayer player, MergeBoardId identifier, int boardWidth, int boardHeight, MetaTime creationTime, IEnumerable<ValueTuple<ItemDefinition, ItemVisibility>> items, IGenerationContext generationContext)
        {
        }

        [MetaMember(11, (MetaMemberFlags)0)]
        public List<MetaDuration> PendingTimeSkips { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public MetaTime ProducerCooldownRemoverEndTime { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public MetaTime ProducerCooldownRemoverStartTime { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public MetaDuration PendingCooldownRemover { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public HashSet<int> DiscoveredItems { get; set; }

        [IgnoreDataMember]
        public int BoardSize { get; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public MetaDuration PendingOnFire { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public MetaTime OnFireStartTime { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public MetaTime OnFireEndTime { get; set; }
    // Process merge for items
    //public void ProcessMerge(Coordinate fromPosition, Coordinate toPosition, MetaTime timeForMergeOrMove,
    //    IPlayer player, IBubbleSpawner bubbleSpawner, IProgressionEventItemSpawner progressionEventItemSpawner,
    //    ICollection<MergeBoardAct> collectedActs)
    //{
    //    var fromItem = GetItem(fromPosition);
    //    var toItem = GetItem(toPosition);
    //    var fromMergeFeatures = fromItem.Definition.MergeFeatures;
    //    fromItem.Definition.IsArtifactItem();
    //    var mergedItem = fromMergeFeatures.Mechanic.Merge(player, fromItem, toItem, timeForMergeOrMove);
    //}
    }
}