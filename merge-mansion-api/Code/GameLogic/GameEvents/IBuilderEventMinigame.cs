using System;

namespace Code.GameLogic.GameEvents
{
    public interface IBuilderEventMinigame
    {
        bool EventCompletionClaimed { get; }

        ITimedRewardSystem TimedRewardSystem { get; }
    }
}