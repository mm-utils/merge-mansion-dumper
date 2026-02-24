using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;

namespace Code.GameLogic.GameEvents
{
    public class BuilderEventTimedRewardsSource : IConfigItemSource<BuilderEventTimedRewardInfo, BuilderEventTimedRewardId>, IGameConfigSourceItem<BuilderEventTimedRewardId, BuilderEventTimedRewardInfo>, IHasGameConfigKey<BuilderEventTimedRewardId>
    {
        public BuilderEventTimedRewardId ConfigKey { get; set; }
        public int RewardAmount { get; set; }
        public string RewardType { get; set; }
        public string RewardId { get; set; }
        public string RewardAux0 { get; set; }
        public string RewardAux1 { get; set; }
        public string Cooldown { get; set; }
        public string Delay { get; set; }
    }
}