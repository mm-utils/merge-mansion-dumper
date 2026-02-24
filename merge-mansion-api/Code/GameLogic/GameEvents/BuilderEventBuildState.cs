using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum BuilderEventBuildState
    {
        NotStarted = 0,
        InProgress = 1,
        Completed = 2,
        Claimed = 3
    }
}