namespace GameLogic.Player.Requirements
{
    public interface IHasRequirement
    {
        PlayerRequirement Requirement { get; }
    }
}