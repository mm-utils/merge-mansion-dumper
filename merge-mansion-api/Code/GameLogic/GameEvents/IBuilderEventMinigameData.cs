using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    public interface IBuilderEventMinigameData
    {
        int Level { get; set; }

        int BuildNumber { get; set; }

        int Points { get; set; }

        BuilderEventCollectionId CollectionId { get; set; }

        CoreSupportEventMinigameId CurrentMinigameId { get; set; }

        BuilderEventBuildId CurrentBuildId { get; set; }

        BuilderEventModeData ModeData { get; set; }

        List<BuilderEventBuildStateData> BuildStates { get; set; }

        TimedRewardData TimedReward { get; set; }

        bool HasSeenInfoPopup { get; set; }

        CoreSupportEventId LastCoreSupportEventId { get; set; }
    }
}