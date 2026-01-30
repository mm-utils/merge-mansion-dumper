using Metaplay.Core.Model;
using System;
using GameLogic.Advertisement;
using GameLogic;
using Merge;
using Metaplay.Core.Offers;
using GameLogic.Player.Board;
using GameLogic.Player.Rewards;
using System.Runtime.Serialization;
using System.Collections.Generic;
using GameLogic.Merge;

namespace Code.GameLogic.Ads
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 4 })]
    public class AdsData : IAdsData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public string AdsProviderIds { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public bool CanBeClaimed { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public AdsRewardType RewardType { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public ShopItemId ShopItemId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public MergeBoardId MergeBoardId { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public OfferPlacementId OfferPlacementId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public Coordinate ItemCoordinates { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public AdvertisementPlacementId AdPlacementId { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public PlayerReward DailyAdReward { get; set; }

        [IgnoreDataMember]
        public ICollection<MergeBoardAct> ProductActs { get; set; }
    }
}