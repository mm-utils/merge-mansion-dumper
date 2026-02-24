using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(19)]
    public class StatsObjectiveEarnBoultonLeagueEventPoints : ASerializedObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}