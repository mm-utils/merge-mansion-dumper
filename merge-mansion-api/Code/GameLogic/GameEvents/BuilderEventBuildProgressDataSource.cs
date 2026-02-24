using Metaplay.Core.Model;
using Code.GameLogic.LevelProgress;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class BuilderEventBuildProgressDataSource : ILevelProgressDataSource
    {
        private CoreSupportEventInfo _eventInfo;
    }
}