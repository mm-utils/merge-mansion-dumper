using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using Analytics;

namespace GameLogic.StatsTracking
{
    [MetaSerializableDerived(4)]
    public class StatsObjectiveBurstBubbles : StatsObjective
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public sealed override long SnapshotAmount { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        public sealed override string ObjectiveId { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public sealed override ObjectiveState State { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public sealed override int ProgressIndex { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public sealed override List<int> ObjectiveRequirements { get; set; }
        public override StatsObjectiveType ObjectiveType { get; }

        public StatsObjectiveBurstBubbles()
        {
        }

        public StatsObjectiveBurstBubbles(IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        [MetaMember(105, (MetaMemberFlags)0)]
        public TaskType TypeTask { get; set; }

        public StatsObjectiveBurstBubbles(IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }
    }
}