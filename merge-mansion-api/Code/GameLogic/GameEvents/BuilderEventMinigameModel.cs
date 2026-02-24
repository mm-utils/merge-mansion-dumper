using Metaplay.Core.Model;
using System;
using System.Collections.Generic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(6)]
    public class BuilderEventMinigameModel : ICoreSupportEventMinigameModel, IBuilderEventMinigame, IDebugBuilderEventMinigame, IRecordableActionProvider
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public CoreSupportEventMinigameId MinigameId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private IBuilderEventMode Mode { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private bool CanStartAnotherBuild { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private ITimedRewardSystem TimedReward { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public bool EventCompletionClaimed { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public Queue<BuilderEventBuildLevelId> UnclaimedMilestones { get; set; }
        public ITimedRewardSystem TimedRewardSystem { get; }
        public ActionRecorder Recorder { get; }
        public bool HasUnclaimedMilestones { get; }
    }
}