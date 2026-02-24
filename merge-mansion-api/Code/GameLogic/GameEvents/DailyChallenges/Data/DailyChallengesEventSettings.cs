using Metaplay.Core.Model;
using Metaplay.Core.Config;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesEventSettings : GameConfigKeyValue<DailyChallengesEventSettings>, IDailyChallengesEventSettings
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DailyChallengesWeekId FallbackPreviousWeekId { get; set; }
    }
}