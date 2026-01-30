using Metaplay.Core.Model;
using Metaplay.Core.Activables;
using GameLogic.ProgressivePacks;
using GameLogic.Player.Rewards;
using System;
using System.Runtime.Serialization;
using GameLogic.StatsTracking;
using Analytics;
using System.Collections.Generic;
using Metaplay.Core;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class ProgressionPackEventModel : MetaActivableState<ProgressionPackEventId, ProgressionPackEventInfo>, IPointsEvent, IGroupIdGetter, ICoreSupportingEventModel
    {
        public static int InitialLevelNumber;
        private static int InitialLevelProgress;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int LevelNumber;
        [MetaMember(3, (MetaMemberFlags)0)]
        public int LevelProgress;
        [MetaMember(4, (MetaMemberFlags)0)]
        public bool StartNoted;
        [MetaMember(5, (MetaMemberFlags)0)]
        public bool EndNoted;
        [MetaMember(6, (MetaMemberFlags)0)]
        public bool EndDialogueTriggered;
        [MetaMember(7, (MetaMemberFlags)0)]
        public bool RewardMailTriggered;
        [MetaMember(8, (MetaMemberFlags)0)]
        public bool BonusRewardsNoted;
        [IgnoreDataMember]
        public bool objectivesProgressLogged;
        public Action<StatsObjective, TaskType, List<PlayerReward>, Action, int, bool> OnLevelUp;
        [MetaMember(1, (MetaMemberFlags)0)]
        public sealed override ProgressionPackEventId ActivableId { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public bool PremiumIAPPurchased { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public StatsObjective CurrentStandardTask { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public List<PlayerReward> ClaimedFreeRewards { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public List<PlayerReward> ClaimedPremiumRewards { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public List<PlayerReward> UnClaimedFreeRewards { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public List<PlayerReward> UnClaimedPremiumRewards { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public bool PassPurchaseNoted { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        public Dictionary<int, ProgressionEventRewardClaimStatus> FreeRewardsStatus { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public Dictionary<int, ProgressionEventRewardClaimStatus> PremiumRewardsStatus { get; set; }
        public IStringId Id { get; }

        private ProgressionPackEventModel()
        {
        }

        public ProgressionPackEventModel(ProgressionPackEventInfo info)
        {
        }

        [IgnoreDataMember]
        public bool RequiresPlayerAttention { get; }
    }
}