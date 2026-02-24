using Metaplay.Core.Model;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public enum TimedRewardState
    {
        NotStarted = 0,
        OnDelay = 1,
        OnCooldown = 2,
        ReadyToClaim = 3,
        Claimed = 4
    }
}