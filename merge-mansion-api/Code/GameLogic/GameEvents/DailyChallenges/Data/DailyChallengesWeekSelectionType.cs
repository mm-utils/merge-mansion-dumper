using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public enum DailyChallengesWeekSelectionType
    {
        Unknown = 0,
        MinigameId = 1,
        PreviousWeekCompletion = 2
    }
}