using System;

namespace Code.GameLogic.GameEvents
{
    public interface IBuilderEventWheelOfFortuneMode : IBuilderEventMode
    {
        int CurrentMultiplierIndex { get; }

        BuilderEventWheelPartId LastSelectedWheelPartId { get; }
    }
}