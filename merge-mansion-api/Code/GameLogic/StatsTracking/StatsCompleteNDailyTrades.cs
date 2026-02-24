using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(12)]
    public class StatsCompleteNDailyTrades : ASerializedObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}