using Metaplay.Core.Model;
using Metaplay.Core.Config;
using System;
using Metaplay.Core;
using System.Collections.Generic;
using GameLogic.Player.Director.Config;
using Metaplay.Core.Math;
using Merge;
using Code.GameLogic.GameEvents;
using Code.GameLogic.Config;
using Metaplay.Core.Player;
using GameLogic.Player;

namespace GameLogic.Config
{
    [MetaSerializable]
    [MetaBlockedMembers(new int[] { 1, 2, 3, 5, 31, 32, 37, 44, 48, 61, 16, 17, 40, 41, 54, 55, 56, 63, 64, 65, 82 })]
    public class SharedGlobals : GameConfigKeyValue<SharedGlobals>, IValidatable
    {
        [MetaMember(4, (MetaMemberFlags)0)]
        public int DefaultActivationCost { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public List<string> ItemTagsRequiringBoosterAnalytics { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public List<IDirectorAction> StartupActions { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public CollectItemsOnSessionStartSettings AutoCollectOnSessionStarted { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public List<int> ProgressionEventBlackListedItems { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public List<string> ItemTagsIgnoredByItemInfoPopup { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public StartingValues StartingValues { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public List<string> ItemTagsIgnoredByLocalizationValidation { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public SpeedUpCostBehavior SpeedUpCostBehavior { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public SpeedUpBehavior SpeedUpBehavior { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public List<int> ItemSellPrices { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        public int PlayerNamePopupTriggerLevel { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        public bool ValidatePlayerNameOnInputEnd { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public F32 DailyTaskWeightAdditive { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public F32 DailyTaskWeightMultiplicative { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public F32 DailyTaskWeightSubtractive { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        public F32 DailyTasksCount { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public MergeBoardId InitBoardId { get; set; }

        [MetaMember(25, (MetaMemberFlags)0)]
        public bool ProgressionEventBubbleBonusesEnabled { get; set; }

        [MetaMember(26, (MetaMemberFlags)0)]
        public bool ForcePlayerName { get; set; }

        [MetaMember(27, (MetaMemberFlags)0)]
        public MetaDuration DialogueInputDelay { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public string PlayerNameDisallowedRegex { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        public MetaDuration DailyTasksDuration { get; set; }

        [MetaMember(30, (MetaMemberFlags)0)]
        public int DailyTasksResetHourUTC { get; set; }

        [MetaMember(33, (MetaMemberFlags)0)]
        public List<MetaRef<EventLevels>> DailyTasksEventLevelSets { get; set; }

        public SharedGlobals()
        {
        }

        [MetaMember(34, (MetaMemberFlags)0)]
        public long MergeHintWaitTimeMilliseconds { get; set; }

        [MetaMember(35, (MetaMemberFlags)0)]
        public List<int> DailyTasksRefreshPricesInDiamonds { get; set; }

        [MetaMember(36, (MetaMemberFlags)0)]
        public int DailyTasksRefreshTasksCount { get; set; }

        [MetaMember(38, (MetaMemberFlags)0)]
        public int ItemsNeededCountDisplayMax { get; set; }

        [MetaMember(39, (MetaMemberFlags)0)]
        public F32 DefaultBubbleBonusDivisor { get; set; }

        [MetaMember(42, (MetaMemberFlags)0)]
        public F32 SinkItemToolTipDisplayDuration { get; set; }

        [MetaMember(43, (MetaMemberFlags)0)]
        public MetaDuration DefaultLockedTaskTimerDuration { get; set; }

        [MetaMember(45, (MetaMemberFlags)0)]
        public MetaDuration MinimumSpeedUpTime { get; set; }

        [MetaMember(46, (MetaMemberFlags)0)]
        public MetaDuration ThirdPartySurveyRewardCheckDuration { get; set; }

        [MetaMember(47, (MetaMemberFlags)0)]
        public bool DailyTasksSkipOldTasksForWeightCalculation { get; set; }

        [MetaMember(49, (MetaMemberFlags)0)]
        public MetaDuration MaintenanceBannerReminderTime { get; set; }

        [MetaMember(50, (MetaMemberFlags)0)]
        public string MergeMansionURL { get; set; }

        [MetaMember(51, (MetaMemberFlags)0)]
        public bool DisableDecayingSpawnerFix { get; set; }

        [MetaMember(52, (MetaMemberFlags)0)]
        public int AdsDailyWatchCap { get; set; }

        [MetaMember(53, (MetaMemberFlags)0)]
        public List<MetaRef<PlayerSegmentInfoBase>> AdsSoftLaunchSegments { get; set; }

        [MetaMember(57, (MetaMemberFlags)0)]
        public int InventorySlotsRequiredToTeaseProducerInventory { get; set; }

        [MetaMember(58, (MetaMemberFlags)0)]
        public int MaxGemCostForOutOfEnergyAds { get; set; }

        [MetaMember(59, (MetaMemberFlags)0)]
        public bool DisableMysteryMachineItemOddsPopup { get; set; }

        [MetaMember(60, (MetaMemberFlags)0)]
        public bool DefaultHapticsEnabled { get; set; }

        [MetaMember(62, (MetaMemberFlags)0)]
        public int MinLevelForAdditionalSpawnItem { get; set; }

        [MetaMember(66, (MetaMemberFlags)0)]
        public int MaxOfferPopupTriggersPerSession { get; set; }

        [MetaMember(67, (MetaMemberFlags)0)]
        public int MaxConsecutiveOfferPopupTriggers { get; set; }

        [MetaMember(68, (MetaMemberFlags)0)]
        public bool UseAlternateShopButtonLayout { get; set; }

        [MetaMember(69, (MetaMemberFlags)0)]
        public bool ShowRewardsInTaskList { get; set; }

        [MetaMember(70, (MetaMemberFlags)0)]
        public int PocketItemsCap { get; set; }

        [MetaMember(71, (MetaMemberFlags)0)]
        public bool AutoLevelUp { get; set; }

        [MetaMember(72, (MetaMemberFlags)0)]
        public bool DisableExperienceItemDrops { get; set; }

        [MetaMember(73, (MetaMemberFlags)0)]
        public bool CacheLastNSegments { get; set; }

        [MetaMember(74, (MetaMemberFlags)0)]
        public FTUEStartGroups FTUEStartGroup { get; set; }

        [MetaMember(75, (MetaMemberFlags)0)]
        private TasksTabStyle TasksTabStyle { get; set; }

        [MetaMember(76, (MetaMemberFlags)0)]
        public bool TabletScalingEnabled { get; set; }

        [MetaMember(77, (MetaMemberFlags)0)]
        public bool TutorializedAreaUnlock { get; set; }

        [MetaMember(78, (MetaMemberFlags)0)]
        public MetaDuration SCIDWarningCooldown { get; set; }

        [MetaMember(79, (MetaMemberFlags)0)]
        public string SCIDWarningEndTime { get; set; }

        [MetaMember(80, (MetaMemberFlags)0)]
        public List<MetaDuration> SCIDWarningEndCooldowns { get; set; }

        [MetaMember(81, (MetaMemberFlags)0)]
        public bool UseUITracking { get; set; }

        [MetaMember(83, (MetaMemberFlags)0)]
        public LocationId InitialLocation { get; set; }

        [MetaMember(84, (MetaMemberFlags)0)]
        public bool UseStreamlinedStoryEventFlow { get; set; }
    }
}