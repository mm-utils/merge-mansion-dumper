using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using System.Collections.Generic;

namespace GameLogic.Decorations
{
    [MetaSerializable]
    public class LayeredDecorationSetInfo : IGameConfigData<LayeredDecorationSetId>, IGameConfigData, IHasGameConfigKey<LayeredDecorationSetId>, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public LayeredDecorationSetId SetId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int RequiredProgressToOwn { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private List<DecorationLayerInfo> LayerInfos { get; set; }
        public LayeredDecorationSetId ConfigKey => SetId;
        public int MaxProgress { get; }
        public List<DecorationLayerInfo> Layers { get; }

        public LayeredDecorationSetInfo()
        {
        }

        public LayeredDecorationSetInfo(LayeredDecorationSetId setId, int requiredProgressToOwn, IEnumerable<DecorationLayerInfo> layers)
        {
        }
    }
}