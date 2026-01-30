using System;
using GameLogic.Advertisement;
using GameLogic;
using Merge;
using Metaplay.Core.Offers;
using GameLogic.Player.Board;
using GameLogic.Player.Rewards;
using System.Collections.Generic;
using GameLogic.Merge;

namespace Code.GameLogic.Ads
{
    public interface IAdsData
    {
        string AdsProviderIds { get; }

        bool CanBeClaimed { get; }

        AdsRewardType RewardType { get; }

        ShopItemId ShopItemId { get; }

        MergeBoardId MergeBoardId { get; }

        OfferPlacementId OfferPlacementId { get; }

        Coordinate ItemCoordinates { get; }

        AdvertisementPlacementId AdPlacementId { get; }

        PlayerReward DailyAdReward { get; }

        ICollection<MergeBoardAct> ProductActs { get; }
    }
}