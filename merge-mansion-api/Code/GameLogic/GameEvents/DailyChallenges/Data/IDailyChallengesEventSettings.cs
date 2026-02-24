namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public interface IDailyChallengesEventSettings
    {
        DailyChallengesWeekId FallbackPreviousWeekId { get; }
    }
}