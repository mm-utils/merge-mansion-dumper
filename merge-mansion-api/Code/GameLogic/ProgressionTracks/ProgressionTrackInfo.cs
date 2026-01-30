using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.GameEvents;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Player.Rewards;
using System;
using Metaplay.Core.Player;

namespace Code.GameLogic.ProgressionTracks
{
    [MetaSerializable]
    public class ProgressionTrackInfo : IProgressionTrackInfo, IGameConfigData<ProgressionTrackId>, IGameConfigData, IHasGameConfigKey<ProgressionTrackId>, ILevelEventInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ProgressionTrackId TrackId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> LevelRefs { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public Dictionary<EventLevelId, MetaRef<EventLevelInfo>> FallbackLevelRefs { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevelInfo>> RecurringLevelRefs { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<PlayerReward> FinalRewards { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<int> ProgressionPopupHeaderImageLevels { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<string> Args { get; set; }
        public ProgressionTrackId ConfigKey => TrackId;
        public IStringId LevelEventId { get; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<PlayerSegmentId> Segments { get; set; }
    }
}