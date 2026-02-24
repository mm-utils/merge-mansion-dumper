using Metaplay.Core.Model;
using Metaplay.Core.Math;
using Code.GameLogic.GameEvents.DailyChallenges.Data;

namespace Code.GameLogic.GameEvents.DailyChallenges
{
    [MetaSerializable]
    public class DailyChallengesEventsHistoricalDataModel : IWriteableDailyChallengesEventsHistoricalDataModel, IDailyChallengesEventsHistoricalDataModel
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public F64 PreviousWeekCompletionRatio { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public DailyChallengesWeekId PreviousWeekId { get; set; }
    }
}