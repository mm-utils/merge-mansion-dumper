using Metaplay.Core.Model;
using GameLogic.StatsTracking;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(14)]
    public class SpendCoreSupportEventTokenObjective : ACoreSupportEventTokenObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }
    }
}