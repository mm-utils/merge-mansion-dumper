using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using Code.GameLogic.GameEvents;
using Metaplay.Core.Player;

namespace Code.GameLogic.ProgressionTracks
{
    public class ProgressionTrackSource : IConfigItemSource<ProgressionTrackInfo, ProgressionTrackId>, IGameConfigSourceItem<ProgressionTrackId, ProgressionTrackInfo>, IHasGameConfigKey<ProgressionTrackId>
    {
        public static string ARG_RESET_WITH_EVENT;
        public static string ARG_HIDE_INITIALLY;
        public static string ARG_EVENT_END_AUTO_CLAIM_REWARDS;
        public ProgressionTrackId ConfigKey { get; set; }
        public string FinalRewards { get; set; }
        public List<string> Args { get; set; }
        public List<MetaRef<EventLevelInfo>> Levels { get; set; }
        public List<PlayerSegmentId> Segments { get; set; }
        public List<MetaRef<EventLevelInfo>> RecurringLevels { get; set; }
    }
}