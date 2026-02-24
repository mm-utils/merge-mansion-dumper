using Metaplay.Core.Model;
using GameLogic.StatsTracking;
using Code.GameLogic.GameEvents;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializableDerived(17)]
    [MetaReservedMembers(201, 300)]
    public class CompleteCoreSupportEventMilestoneObjective : ASerializedObjectiveBase
    {
        public sealed override StatsObjectiveType ObjectiveType { get; }

        [MetaMember(201, (MetaMemberFlags)0)]
        public CoreSupportEventType CoreSupportEventType { get; set; }
    }
}