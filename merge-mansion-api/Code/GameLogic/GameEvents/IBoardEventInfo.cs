using Metaplay.Core;
using Metaplay.Core.Offers;
using GameLogic.Story;
using GameLogic.Player.Requirements;
using GameLogic.Decorations;
using Metaplay.Core.Activables;
using GameLogic.Config;
using System.Collections.Generic;
using GameLogic.Player.Rewards;
using System;
using Merge;
using Code.GameLogic.IAP;

namespace Code.GameLogic.GameEvents
{
    public interface IBoardEventInfo : IHasRequirement
    {
        PlayerRequirement UnlockRequirement { get; }

        DecorationInfo ActiveDecoration { get; }

        ExtendableEventParams ExtendableEventParams { get; }

        MetaRef<InAppProductInfo> ExtensionInAppProduct { get; }

        MetaDuration ExtensionPurchaseSafetyMargin { get; }

        MergeBoardId MergeBoardId { get; }

        IStringId BoardEventId { get; }

        MetaActivableParams ActivableParams { get; }

        string Description { get; }
    }
}