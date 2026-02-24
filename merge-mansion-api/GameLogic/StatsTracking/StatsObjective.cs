using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using Analytics;
using Code.GameLogic.StatsTracking;

namespace GameLogic.StatsTracking
{
    [MetaSerializable]
    public abstract class StatsObjective : IStatsObjective
    {
        public abstract StatsObjectiveType ObjectiveType { get; }
        public abstract long SnapshotAmount { get; set; }
        public abstract string ObjectiveId { get; set; }
        public abstract ObjectiveState State { get; set; }
        public abstract int ProgressIndex { get; set; }
        public abstract List<int> ObjectiveRequirements { get; set; }

        protected StatsObjective()
        {
        }

        [IgnoreDataMember]
        public int LastProgress { get; set; }
    }
}