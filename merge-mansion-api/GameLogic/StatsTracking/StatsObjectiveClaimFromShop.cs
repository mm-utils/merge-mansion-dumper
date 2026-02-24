using Metaplay.Core.Model;
using Metaplay.Core;
using GameLogic.Player.Items;
using System;
using System.Collections.Generic;
using Analytics;
using GameLogic.Config;

namespace GameLogic.StatsTracking
{
    [MetaSerializableDerived(6)]
    public class StatsObjectiveClaimFromShop : StatsObjective
    {
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

        public StatsObjectiveClaimFromShop()
        {
        }

        public StatsObjectiveClaimFromShop(string targetItemType, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        public StatsObjectiveClaimFromShop(MetaRef<ItemDefinition> targetItem, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        public StatsObjectiveClaimFromShop(IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements)
        {
        }

        [MetaMember(106, (MetaMemberFlags)0)]
        public TaskType TypeTask { get; set; }

        public StatsObjectiveClaimFromShop(string targetItemType, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }

        public StatsObjectiveClaimFromShop(MetaRef<ItemDefinition> targetItem, IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }

        public StatsObjectiveClaimFromShop(IStringId objectiveId, long snapshotAmount, List<int> objectiveRequirements, TaskType typeTask)
        {
        }

        [MetaMember(100, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        private ItemDef TargetItemDef { get; set; }
    }
}