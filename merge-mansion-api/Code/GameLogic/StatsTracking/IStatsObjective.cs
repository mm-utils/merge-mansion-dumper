using Metaplay.Core.Model;
using GameLogic.StatsTracking;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializable]
    public interface IStatsObjective
    {
        StatsObjectiveType ObjectiveType { get; }

        long SnapshotAmount { get; }

        string ObjectiveId { get; }

        ObjectiveState State { get; set; }

        int ProgressIndex { get; set; }

        List<int> ObjectiveRequirements { get; }

        int LastProgress { get; }
    }
}