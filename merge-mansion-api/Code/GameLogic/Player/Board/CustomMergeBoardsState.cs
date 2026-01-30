using Metaplay.Core.Model;
using System.Collections.Generic;
using Merge;
using GameLogic.Player.Board;

namespace Code.GameLogic.Player.Board
{
    [MetaSerializable]
    public class CustomMergeBoardsState : ICustomMergeBoardsState, IWritableCustomMergeBoardsState
    {
        public Dictionary<MergeBoardId, MergeBoard> MergeBoards { get; set; }
    }
}