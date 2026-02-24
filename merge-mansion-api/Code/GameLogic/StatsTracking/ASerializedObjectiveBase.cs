using Metaplay.Core.Model;
using GameLogic.StatsTracking;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializable]
    [MetaReservedMembers(101, 200)]
    public abstract class ASerializedObjectiveBase : StatsObjective
    {
        [MetaMember(101, (MetaMemberFlags)0)]
        public sealed override string ObjectiveId { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        public sealed override ObjectiveState State { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public sealed override int ProgressIndex { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public sealed override List<int> ObjectiveRequirements { get; set; }

        [MetaMember(105, (MetaMemberFlags)0)]
        public sealed override long SnapshotAmount { get; set; }
    }
}