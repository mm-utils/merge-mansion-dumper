using GameLogic.Player.Requirements;

namespace Code.GameLogic.GameEvents
{
    public interface ILevelBoardEventInfo : ILevelEventInfo, IBoardEventInfo, IHasRequirement
    {
    }
}