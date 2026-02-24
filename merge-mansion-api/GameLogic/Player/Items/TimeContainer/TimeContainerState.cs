using Metaplay.Core.Model;
using Metaplay.Core;

namespace GameLogic.Player.Items.TimeContainer
{
    [MetaSerializable]
    public class TimeContainerState : IWritableTimeContainerState, ITimeContainerState
    {
        public MetaDuration Remaining { get; set; }

        public TimeContainerState()
        {
        }
    }
}