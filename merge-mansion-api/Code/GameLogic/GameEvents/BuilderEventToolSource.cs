using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventToolSource : IConfigItemSource<BuilderEventToolInfo, BuilderEventToolId>, IGameConfigSourceItem<BuilderEventToolId, BuilderEventToolInfo>, IHasGameConfigKey<BuilderEventToolId>
    {
        public BuilderEventToolId ConfigKey { get; set; }
        public string AssetId { get; set; }
        public int AwardedPoints { get; set; }
        public int TokenCost { get; set; }
        public List<int> PriceCost { get; set; }
        public List<Currencies> PriceCurrency { get; set; }
    }
}