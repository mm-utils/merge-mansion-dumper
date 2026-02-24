using Metaplay.Core.Model;
using System.Collections.Generic;
using GameLogic.Config;
using System.Runtime.Serialization;

namespace GameLogic.Player.Requirements
{
    [MetaSerializable]
    public class MergeItemFilterComponent
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private List<ItemDef> _itemDefinitions;
        [MetaMember(2, (MetaMemberFlags)0)]
        private List<MergeChainDef> _mergeChainDefinitions;
        [IgnoreDataMember]
        public List<ItemDef> ItemDefinitions { get; }

        [IgnoreDataMember]
        public List<MergeChainDef> MergeChainDefinitions { get; }
    }
}