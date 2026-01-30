using System;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    public interface IEventSharedInfo
    {
        int Priority { get; }

        string SharedEventId { get; }

        EventCategoryInfo CategoryInfo { get; }

        Option<EventGroupId> GroupIdOption { get; }
    }
}