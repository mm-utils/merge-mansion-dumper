using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventToolInfo : IGameConfigData<BuilderEventToolId>, IGameConfigData, IHasGameConfigKey<BuilderEventToolId>
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public BuilderEventToolId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int AwardedPoints { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int TokenCost { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<int> PriceCost { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<Currencies> PriceCurrency { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string AssetId { get; set; }
    }
}