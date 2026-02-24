using Metaplay.Core.Model;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(2)]
    public class BuilderEventWheelOfFortuneMode : IBuilderEventWheelOfFortuneMode, IBuilderEventMode
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public int CurrentMultiplierIndex { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public BuilderEventWheelPartId LastSelectedWheelPartId { get; set; }
    }
}