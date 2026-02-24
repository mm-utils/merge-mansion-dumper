using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(11)]
    public class StatsObjectiveEarnMysteryPassPoints : ASerializedObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}