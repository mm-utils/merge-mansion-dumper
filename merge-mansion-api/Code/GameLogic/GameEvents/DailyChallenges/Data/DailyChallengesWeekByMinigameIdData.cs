using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Game.Cloud.Config;
using System.Collections.Generic;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengesWeekByMinigameIdData : IGameConfigData<DailyChallengesMinigameId>, IGameConfigData, IHasGameConfigKey<DailyChallengesMinigameId>
    {
        public DailyChallengesMinigameId ConfigKey => ConfigId.ConfigKey;

        [MetaMember(1, (MetaMemberFlags)0)]
        public ConfigId<DailyChallengesMinigameId, DailyChallengesMinigameData> ConfigId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private List<PlayerSegmentId> WeekSegments { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private List<ConfigId<DailyChallengesWeekId, DailyChallengesWeekData>> WeeksIds { get; set; }
    }
}