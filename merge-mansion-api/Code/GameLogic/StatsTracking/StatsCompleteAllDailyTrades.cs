using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(13)]
    [MetaReservedMembers(201, 300)]
    public class StatsCompleteAllDailyTrades : ASerializedObjectiveBase
    {
        [MetaMember(201, (MetaMemberFlags)0)]
        private StatsCompleteNDailyTrades _completeNDailyTrades;
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}