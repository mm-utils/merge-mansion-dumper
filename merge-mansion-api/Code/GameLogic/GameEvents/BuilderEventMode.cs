using Metaplay.Core.Model;
using GameLogic;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum BuilderEventMode
    {
        Tools = 0,
        WheelOfFortune = 1
    }
}