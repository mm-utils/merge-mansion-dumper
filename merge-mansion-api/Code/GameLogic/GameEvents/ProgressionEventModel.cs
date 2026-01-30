using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using System;
using GameLogic.Story;
using System.Collections.Generic;
using GameLogic.Player;
using Metaplay.Core;
using GameLogic.Player.Rewards;
using System.Runtime.Serialization;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializableDerived(6)]
    public class ProgressionEventModel : MetaActivableState<ProgressionEventId, ProgressionEventInfo>, IPointsEvent, IGroupIdGetter
    {
        public static int InitialLevelNumber;
        private static int InitialLevelProgress;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int LevelNumber;
        [MetaMember(3, (MetaMemberFlags)0)]
        public int LevelProgress;
        [MetaMember(6, (MetaMemberFlags)0)]
        public bool StartNoted;
        [MetaMember(8, (MetaMemberFlags)0)]
        public bool EndNoted;
        [MetaMember(12, (MetaMemberFlags)0)]
        public bool EndDialogueTriggered;
        [MetaMember(11, (MetaMemberFlags)0)]
        public HashSet<StoryDefinitionId> TriggeredLevelRewardClaimedStories;
        [MetaMember(13, (MetaMemberFlags)0)]
        public BoardInventory ExtraInventory;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override ProgressionEventId ActivableId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public List<int> ClaimedFreeLevelNumbers { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public List<int> ClaimedPremiumLevelNumbers { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public Dictionary<ProgressionEventPerkId, MetaTime> LatestFreeShopItemPerkUsageTimesById { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public Dictionary<ProgressionEventPerkId, MetaTime> LatestFreeDailyShopItemPerkUsageTimesById { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public Dictionary<ProgressionEventPerkId, MetaTime> LatestFreeDailyCurrencyPerkUsageTimeById { get; set; }

        private ProgressionEventModel()
        {
        }

        public ProgressionEventModel(ProgressionEventInfo info)
        {
        }

        [MetaMember(16, (MetaMemberFlags)0)]
        public bool StreakNoted;
        public IStringId Id { get; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public bool PassPurchaseNoted { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public bool PassObtainedPopupNoted { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        public bool BonusRewardsNoted;
        [MetaMember(20, (MetaMemberFlags)0)]
        public List<int> ClaimedTrack2LevelNumbers { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public List<int> ClaimedChallengeRewards { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public bool PremiumIAPPurchased { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        private ProgressionEventTrack ActiveIAPTrack { get; set; }

        [IgnoreDataMember]
        public ProgressionEventTrack ActiveTrack { get; }

        [MetaMember(22, (MetaMemberFlags)0)]
        private int LastLevelNoted { get; set; }

        private static int InvalidProgressValue;
        [MetaMember(9, (MetaMemberFlags)0)]
        public bool OnReviewEndedActionsTriggered;
    }
}