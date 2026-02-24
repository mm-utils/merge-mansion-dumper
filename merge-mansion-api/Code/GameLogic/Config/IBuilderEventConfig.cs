using Code.GameLogic.GameEvents;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.Config
{
    public interface IBuilderEventConfig
    {
        Dictionary<CoreSupportEventMinigameId, BuilderEventMinigameInfo> Minigames { get; }

        Dictionary<BuilderEventCollectionId, BuilderEventCollectionInfo> Collections { get; }

        Dictionary<BuilderEventBuildLevelId, BuilderEventBuildInfo> Builds { get; }

        Dictionary<int, BuilderEventBuildInfo[]> BuildsByBuildNumber { get; }

        Dictionary<BuilderEventToolId, BuilderEventToolInfo> Tools { get; }

        Dictionary<BuilderEventWheelId, BuilderEventWheelInfo> Wheels { get; }

        Dictionary<BuilderEventWheelPartId, BuilderEventWheelPartInfo> WheelParts { get; }

        Dictionary<BuilderEventTimerId, BuilderEventTimerInfo> Timers { get; }

        Dictionary<BuilderEventTimedRewardId, BuilderEventTimedRewardInfo> TimedRewards { get; }
    }
}