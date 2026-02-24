using Metaplay.Core.Model;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using Analytics;

namespace GameLogic.StatsTracking
{
    [MetaSerializableDerived(2)]
    public class StatsObjectiveSpendResource : StatsObjective
    {
        [MetaMember(100, (MetaMemberFlags)0)]
        public Currencies TargetResource { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        public sealed override long SnapshotAmount { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public sealed override string ObjectiveId { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public sealed override ObjectiveState State { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public sealed override int ProgressIndex { get; set; }

        [MetaMember(105, (MetaMemberFlags)0)]
        public sealed override List<int> ObjectiveRequirements { get; set; }
        public override StatsObjectiveType ObjectiveType { get; }

        public StatsObjectiveSpendResource()
        {
        }

        public StatsObjectiveSpendResource(string targetItemId, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        public StatsObjectiveSpendResource(Currencies targetResource, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        [MetaMember(106, (MetaMemberFlags)0)]
        public TaskType TypeTask { get; set; }

        public StatsObjectiveSpendResource(string targetItemId, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }

        public StatsObjectiveSpendResource(Currencies targetResource, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }
    }
}