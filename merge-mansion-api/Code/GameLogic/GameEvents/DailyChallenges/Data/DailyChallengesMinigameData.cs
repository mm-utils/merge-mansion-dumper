using Metaplay.Core.Model;
using Metaplay.Core.Config;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesMinigameData : IGameConfigData<DailyChallengesMinigameId>, IGameConfigData, IHasGameConfigKey<DailyChallengesMinigameId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesMinigameId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public DailyChallengesWeekSelectionType WeekSelectionType { get; set; }
    }
}