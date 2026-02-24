using Metacore.MergeMansion.Common.Options;
using System;
using GameLogic.Player.Items;
using Metaplay.Core.Schedule;

namespace Code.GameLogic.GameEvents
{
    public interface ICoreSupportEventInfo : IEventSharedInfo, ILevelEventInfo
    {
        CoreSupportEventId ConfigKey { get; }

        CoreSupportEventType EventType { get; }

        Option<CoreSupportEventMinigameId> MinigameIdOption { get; }

        string AssetId { get; }

        string LocIdPrefix { get; }

        Option<CoreSupportEventCollectionId> CollectionIdOption { get; }

        string NameLocId { get; }

        CoreSupportEventStartPopupAction StartPopupAction { get; }

        CoreSupportEventTokenTarget FallbackTokenTarget { get; }

        CoreSupportEventTokenType TokenType { get; }

        Option<CoreSupportEventTokenId> TokenIdOption { get; }

        MetaRecurringCalendarSchedule Schedule { get; }
    }
}