using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum CoreSupportEventType
    {
        None = 0,
        DigEvent = 1,
        ClassicRaces = 2,
        AutoMerge = 3,
        RollTheDice = 4,
        DailyChallengesEvent = 5,
        BuilderEvent = 6
    }
}