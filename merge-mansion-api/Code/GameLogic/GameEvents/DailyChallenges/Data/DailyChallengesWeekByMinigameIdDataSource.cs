using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System.Collections.Generic;
using Metaplay.Core.Player;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    public class DailyChallengesWeekByMinigameIdDataSource : IConfigItemSource<DailyChallengesWeekByMinigameIdData, DailyChallengesMinigameId>, IGameConfigSourceItem<DailyChallengesMinigameId, DailyChallengesWeekByMinigameIdData>, IHasGameConfigKey<DailyChallengesMinigameId>
    {
        public DailyChallengesMinigameId ConfigKey { get; set; }
        private List<PlayerSegmentId> WeekSegments { get; set; }
        private List<DailyChallengesWeekId> WeeksIds { get; set; }
    }
}