using Merge;
using GameLogic.Player.Board;
using System.Collections.Generic;

namespace Code.GameLogic.Player.Board
{
    public interface ICustomMergeBoardsState
    {
        Dictionary<MergeBoardId, MergeBoard> MergeBoards { get; }
    }
}