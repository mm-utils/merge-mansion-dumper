using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(15)]
    public class EarnCoreSupportEventTokenObjective : ACoreSupportEventTokenObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}