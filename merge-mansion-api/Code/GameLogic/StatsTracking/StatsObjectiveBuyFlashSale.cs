using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(16)]
    public class StatsObjectiveBuyFlashSale : ASerializedObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}