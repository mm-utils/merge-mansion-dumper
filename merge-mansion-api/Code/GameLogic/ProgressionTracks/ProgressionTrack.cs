using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using GameLogic.Player.Rewards;
using System;
using System.Collections.Generic;
using Metaplay.Core;

namespace Code.GameLogic.ProgressionTracks
{
    [MetaSerializable]
    public class ProgressionTrack : IProgressionTrack, ILevelEventModel, IPointsEvent
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ProgressionTrackId TrackId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public ProgressionTrackInfo TrackInfo { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public int Level { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public int LevelProgress { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<LevelEventClaimedLevelData> ClaimedLevels { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public bool FinalRewardClaimed { get; set; }
        public bool IsCompleted { get; }
        public ProgressionTrackId ConfigKey { get; }
        public ILevelEventInfo LevelEventInfo { get; }
        public IStringId Id { get; }
    }
}