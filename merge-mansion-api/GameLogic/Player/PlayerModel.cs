using Metaplay.Core.Model;
using Metaplay.Core.Player;
using Game.Logic;
using GameLogic.Random;
using System;
using Merge;
using Metaplay.Core;
using System.Collections.Generic;
using System.Runtime.Serialization;
using GameLogic.Merge;
using GameLogic.Config;
using GameLogic.Offers;
using Code.GameLogic.GameEvents;
using GameLogic.Banks;
using GameLogic.Player.Board;
using GameLogic.Player.DailyTasks;
using GameLogic.Player.Modifiers;
using GameLogic.Player.Director;
using GameLogic.GameFeatures;
using Analytics;
using GameLogic.Player.ScheduledActions;
using Metaplay.Core.Math;
using GameLogic.Player.Leaderboard;
using Game.Logic.Mail;
using GameLogic.Player.Director.Actions;
using GameLogic.Player.Director.Conditions;
using GameLogic.Inventory;
using GameLogic.Config.DecorationShop;
using GameLogic.Player.Modes;
using Code.GameLogic.DynamicEvents;
using Game.Cloud.Webshop;
using GameLogic.Player.DailyTasksV2;
using Metaplay.Core.Debugging;
using System.Runtime.CompilerServices;
using GameLogic.Config.EnergyModeEvent;
using GameLogic.MiniEvents;
using GameLogic.Player.Events;
using Code.GameLogic.Player.Events.DailyScoopEvent;
using GameLogic.Player.Items;
using GameLogic.Player.Leaderboard.BoultonLeague;
using GameLogic.Player.Leaderboard.ShortLeaderboardEvent;
using Code.GameLogic.GameEvents.CardCollectionSupportingEvent;
using GameLogic.MixABooster;
using Code.GameLogic.Player.Board;
using GameLogic.Player.Events.AdStampCardEvent;
using GameLogic.Player.Leaderboard.ClassicRacesEvent;
using Code.GameLogic.Player;
using GameLogic.Config.Types;
using GameLogic.Utility;
using Code.GameLogic.Config;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Player
{
    [MetaSerializableDerived(1)]
    [MetaReservedMembers(99, 400)]
    [MetaReservedMembers(11, 12)]
    [MetaBlockedMembers(new int[] { 6, 108, 110, 112, 114, 116, 117, 200, 205, 208, 220, 224, 239, 241, 251, 233, 274, 285, 249, 216, 299, 309 })]
    [SupportedSchemaVersions(21, 56)]
    public class PlayerModel : PlayerModelBase<PlayerModel, PlayerStatisticsCore, PlayerMergeMansionOffersGroupModel, PlayerGuildStateCore>, IWritablePlayer, IPlayer, IGenerationContext
    {
        public static int MaxLoginCounts;
        public static int MaxEnergySpentDays;
        public static int MaxMoneySpentDays;
        public static int TicksPerSecond;
        [ServerOnly]
        [MetaMember(211, (MetaMemberFlags)0)]
        [Transient]
        public Dictionary<MergeBoardId, MetaTime> BoardActivationsLeftAnalyticsEvents;
        [IgnoreDataMember]
        private ICollection<MergeBoardAct> updateActs;
        [Obsolete("use MergeMansionGameConfig instead")]
        [IgnoreDataMember]
        public SharedGameConfig GameConfig { get; }

        [IgnoreDataMember]
        public IPlayerModelServerListener ServerListener { get; set; }

        [IgnoreDataMember]
        public IPlayerModelClientListener ClientListener { get; set; }
        public sealed override int PlayerLevel { get; set; }

        [IgnoreDataMember]
        public PlayerLocalTime CurrentLocalTime { get; }

        [IgnoreDataMember]
        public IEnumerable<IActiveOfferGroup> ActiveOfferGroups { get; }

        [IgnoreDataMember]
        public SpawnFactoryState SpawnState { get; }

        [IgnoreDataMember]
        public GarageCleanupEventModel GarageCleanupEventModel { get; }

        [IgnoreDataMember]
        public CurrencyBankModel CurrencyBankModel { get; }

        [MetaMember(11, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public RandomPCG Random { get; set; }

        [MetaMember(99, (MetaMemberFlags)0)]
        public sealed override EntityId PlayerId { get; set; }

        [MetaMember(100, (MetaMemberFlags)0)]
        [NoChecksum]
        public GameSettings GameSettings { get; set; }

        [MetaMember(101, (MetaMemberFlags)0)]
        [NoChecksum]
        public Statistics Statistics { get; set; }

        [MetaMember(102, (MetaMemberFlags)0)]
        [NoChecksum]
        public PlayerIdentity PlayerIdentity { get; set; }

        [MetaMember(103, (MetaMemberFlags)0)]
        public Wallet Wallet { get; set; }

        [MetaMember(104, (MetaMemberFlags)0)]
        public ProgressState ProgressState { get; set; }

        [MetaMember(105, (MetaMemberFlags)0)]
        public StoreStatus StoreStatus { get; set; }

        [MetaMember(106, (MetaMemberFlags)0)]
        public SpawnFactoryState SpawnFactoryState { get; set; }

        [IgnoreDataMember]
        public IBoardInventory GarageBoardInventory { get; set; }

        [MetaMember(109, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public MergeBoard GarageMergeBoard { get; set; }

        [MetaMember(111, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public MergeBoard EventMergeBoard { get; set; }

        [MetaMember(113, (MetaMemberFlags)0)]
        public WeightedDistributionStates DistributionStates { get; set; }

        [MetaMember(115, (MetaMemberFlags)0)]
        public DailyTaskStatus DailyTaskStatus { get; set; }

        [MetaMember(201, (MetaMemberFlags)0)]
        [Transient]
        public MergeBoardId ActiveMergeBoardId { get; set; }

        [MetaMember(202, (MetaMemberFlags)0)]
        public PlayerBoardEventsModel BoardEvents { get; set; }

        [MetaMember(203, (MetaMemberFlags)0)]
        public PlayerShopEventsModel ShopEvents { get; set; }

        [MetaMember(204, (MetaMemberFlags)0)]
        private List<IPlayerModifier> PlayerModifiers { get; set; }

        [MetaMember(206, (MetaMemberFlags)0)]
        private int ScriptedEventNextId { get; set; }

        [MetaMember(207, (MetaMemberFlags)0)]
        private List<ScriptedEvent> RegisteredScriptedEvents { get; set; }

        [MetaMember(210, (MetaMemberFlags)0)]
        public PlayerGarageCleanupEventsModel GarageCleanupEvents { get; set; }

        [MetaMember(212, (MetaMemberFlags)0)]
        public PlayerProgressionEventsModel ProgressionEvents { get; set; }

        [MetaMember(213, (MetaMemberFlags)0)]
        private bool HadArtifactsEnabled { get; set; }

        [MetaMember(214, (MetaMemberFlags)0)]
        public GameFeaturesStates UnlockedFeatures { get; set; }

        [MetaMember(215, (MetaMemberFlags)0)]
        [NoChecksum]
        public List<MetaTime> SessionsInTheLast240HoursStartAt { get; set; }

        [MetaMember(217, (MetaMemberFlags)0)]
        [Transient]
        public string AnalyticsApiKey { get; set; }

        [MetaMember(218, (MetaMemberFlags)0)]
        [NoChecksum]
        public SortedDictionary<int, int> LoginCountsPerDay { get; set; }

        [MetaMember(219, (MetaMemberFlags)0)]
        public HashSet<PlayerSegmentId> ForcedSegments { get; set; }

        [MetaMember(261, (MetaMemberFlags)0)]
        [ServerOnly]
        public Queue<PlayerAnalyticsEventDPL2> AnalyticsEvents { get; set; }

        [MetaMember(221, (MetaMemberFlags)0)]
        [ServerOnly]
        public int NumOfResets { get; set; }

        [MetaMember(222, (MetaMemberFlags)0)]
        public PlayerScheduledActions ScheduledActions { get; set; }

        [MetaMember(223, (MetaMemberFlags)0)]
        public CurrencyBanksModel CurrencyBanksModel { get; set; }

        [MetaMember(225, (MetaMemberFlags)0)]
        public ClientPlatform LastClientPlatform { get; set; }

        [MetaMember(226, (MetaMemberFlags)0)]
        public PlayerCollectibleBoardEventsModel CollectibleBoardEvents { get; set; }

        [MetaMember(227, (MetaMemberFlags)0)]
        [NoChecksum]
        public sealed override string PlayerName { get; set; }

        [MetaMember(228, (MetaMemberFlags)0)]
        public PlayerLeaderboardEventsModel LeaderboardEvents { get; set; }

        [MetaMember(229, (MetaMemberFlags)0)]
        public ulong Flags { get; set; }

        [MetaMember(230, (MetaMemberFlags)0)]
        public SortedDictionary<int, F64> MoneySpentPerDay { get; set; }

        [MetaMember(231, (MetaMemberFlags)0)]
        public SortedDictionary<int, long> EnergySpentPerDay { get; set; }

        [MetaMember(232, (MetaMemberFlags)0)]
        public ReEngagementSettingsId ReEngagementSettingsId { get; set; }

        [MetaMember(234, (MetaMemberFlags)0)]
        public MetaDuration DebugTimeOffsetValue { get; set; }
        public override MetaDuration DebugTimeOffset { get; }

        [IgnoreDataMember]
        public IEnumerable<IBoard> Boards { get; }

        [IgnoreDataMember]
        public IEnumerable<ValueTuple<IBoard, MetaTime?>> BoardsWithExpirationTimes { get; }
        public IEnumerable<IMailMessage> MailMessages { get; }
        public IEnumerable<GarageCleanupEventModel> ActiveGarageCleanups { get; }
        public IEnumerable<BoardEventModel> ActiveBoardEvents { get; }
        public IEnumerable<CollectibleBoardEventModel> ActiveCollectibleBoardEvents { get; }
        public IEnumerable<LeaderboardEventModel> ActiveLeaderboardEvents { get; }
        public IEnumerable<ShopEventModel> ActiveShopEvents { get; }
        public IEnumerable<ProgressionEventModel> ActiveProgressionEvents { get; }
        public IEnumerable<IPlayerModifier> ActiveModifiers { get; }

        [IgnoreDataMember]
        public List<ScriptedEvent> ScriptedEvents { get; }

        public PlayerModel()
        {
        }

        [MetaMember(209, (MetaMemberFlags)0)]
        public Dictionary<int, ThirdPartySurveyStatus> CompletedThirdPartySurveys { get; set; }

        [MetaMember(235, (MetaMemberFlags)0)]
        private List<ProgressionEventId> ProgressionEventIAPStreaks { get; set; }

        [IgnoreDataMember]
        public IBoardInventory RentableBoardInventory { get; set; }

        [MetaMember(237, (MetaMemberFlags)0)]
        public MetaTime RentableInventoryExpirationTime { get; set; }

        [MetaMember(238, (MetaMemberFlags)0)]
        public int RentableInventoryBoughtBatchCount { get; set; }

        [IgnoreDataMember]
        public ValueTuple<IBoardInventory, MetaTime?> RentableInventory { get; }

        [IgnoreDataMember]
        public bool IsRentableInventoryExpired { get; }

        [IgnoreDataMember]
        public int ProgressionEventIAPStreakLength { get; }

        [IgnoreDataMember]
        public IBoardInventory GarageBoardProducerInventory { get; set; }

        [MetaMember(244, (MetaMemberFlags)0)]
        private MetaTime? previousIntervalCheckTime;
        [MetaMember(242, (MetaMemberFlags)0)]
        public RentableInventoryState RentableInventoryState { get; set; }

        [MetaMember(243, (MetaMemberFlags)0)]
        public List<string> UnlockedSongs { get; set; }

        [MetaMember(245, (MetaMemberFlags)0)]
        public PlayerDecorationShopsModel DecorationShops { get; set; }

        [MetaMember(247, (MetaMemberFlags)0)]
        [Transient]
        public bool IsProductionEnvironment { get; set; }
        public DynamicEventTaskStatus DynamicEventTaskStatus { get; set; }
        public PlayerModifiersChangedEvent ModifiersChanged { get; set; }
        public PlayerModesChangedEvent ModesChanged { get; set; }

        [MetaMember(250, (MetaMemberFlags)0)]
        public PlayerSideBoardEventsModel SideBoardEvents { get; set; }

        [MetaMember(252, (MetaMemberFlags)0)]
        public Dictionary<int, RandomPCG> RandomsByFishingRodType { get; set; }

        [MetaMember(253, (MetaMemberFlags)0)]
        public OverrideSpawnItemsStatus OverrideSpawnItemsStatus { get; set; }
        public IEnumerable<SideBoardEventModel> ActiveSideBoardEvents { get; }
        public IEnumerable<GarageCleanupEventModel> AllGarageCleanups { get; }
        public IEnumerable<SideBoardEventModel> AllSideBoardEvents { get; }
        public List<IPlayerModifier> ActiveModifiersNonAlloc { get; }

        [MetaMember(254, (MetaMemberFlags)0)]
        public WebshopState WebshopState { get; set; }

        [MetaMember(255, (MetaMemberFlags)0)]
        public PlayerMysteryMachineEventsModel MysteryMachineEvents { get; set; }

        [MetaMember(256, (MetaMemberFlags)0)]
        public RandomPCG MysteryMachineRandom { get; set; }

        [MetaMember(257, (MetaMemberFlags)0)]
        public int MysteryMachineEventsStarted { get; set; }
        public IEnumerable<MysteryMachineEventModel> ActiveMysteryMachineEvents { get; }

        [MetaMember(258, (MetaMemberFlags)0)]
        [NoChecksum]
        public bool MysteryMachineAllTasksCompletedRewardClaimed_DEPRECATED { get; set; }

        [IgnoreDataMember]
        public List<IWritableProducerInventorySlotState> ProducerInventoryEntries { get; set; }

        [MetaMember(260, (MetaMemberFlags)0)]
        public int MysteryMachineAllTasksCompletedRewardClaimedEventInstance { get; set; }

        [IgnoreDataMember]
        public string SessionConfigVersion { get; set; }

        [IgnoreDataMember]
        public string ServerBuildVersion { get; set; }

        [MetaMember(262, (MetaMemberFlags)0)]
        [NoChecksum]
        public Dictionary<MetaTime, MetaDuration> SessionData { get; set; }

        [MetaMember(263, (MetaMemberFlags)0)]
        public DailyTasksV2Status DailyTasksV2Status { get; set; }

        [MetaMember(264, (MetaMemberFlags)0)]
        public bool HasAds { get; set; }

        [MetaMember(265, (MetaMemberFlags)0)]
        [NoChecksum]
        public UnitySystemInfo UnitySystemInfo { get; set; }

        [MetaMember(266, (MetaMemberFlags)0)]
        public PlayerEnergyModeEventsModel EnergyModeEvents { get; set; }

        [MetaMember(267, (MetaMemberFlags)0)]
        public PlayerMiniEventsModel MiniEvents { get; set; }

        [MetaMember(268, (MetaMemberFlags)0)]
        public PlayerMiniEventOverrides MiniEventOverrides { get; set; }

        [MetaMember(269, (MetaMemberFlags)0)]
        public PlayerSoloMilestoneEventModel SoloMilestoneEvents { get; set; }

        [MetaMember(270, (MetaMemberFlags)0)]
        public int SoloMilestoneEventsStarted { get; set; }

        [MetaMember(271, (MetaMemberFlags)0)]
        public RandomPCG SoloMilestoneRandom { get; set; }

        [MetaMember(272, (MetaMemberFlags)0)]
        public PlayerDailyScoopEventModel DailyScoopEvents { get; set; }

        [MetaMember(273, (MetaMemberFlags)0)]
        [ServerOnly]
        public List<int> MassMailsReceived { get; set; }

        [IgnoreDataMember]
        public LeaderboardClientState LeaderboardClientState { get; }
        public IEnumerable<DailyScoopEventModel> ActiveDailyScoopEvents { get; }
        public IEnumerable<SoloMilestoneEventModel> ActiveSoloMilestoneEvents { get; }
        public IEnumerable<MiniEventModel> ActiveMiniEvents { get; }

        [IgnoreDataMember]
        public Dictionary<string, Coordinate> BubblesWithAds { get; }

        [MetaMember(275, (MetaMemberFlags)0)]
        public RandomPCG RewardContainerRandom { get; set; }

        [MetaMember(276, (MetaMemberFlags)0)]
        public PlayerMysteryMachineLeaderboardRewardsState MysteryMachineLeaderboardRewardsState { get; set; }

        [MetaMember(277, (MetaMemberFlags)0)]
        public PlayerBoultonLeagueEventsModel BoultonLeagueEvents { get; set; }

        [MetaMember(278, (MetaMemberFlags)0)]
        public BoultonLeagueStatus BoultonLeagueStatus { get; set; }

        [MetaMember(279, (MetaMemberFlags)0)]
        public PlayerTemporaryCardCollectionEventsModel TemporaryCardCollectionEvents { get; set; }

        [MetaMember(280, (MetaMemberFlags)0)]
        [NoChecksum]
        public Dictionary<string, Coordinate> bubbleAdsDictionary { get; set; }

        [IgnoreDataMember]
        public BoultonLeagueDivisionClientState BoultonLeagueDivisionClientState { get; }
        public IEnumerable<TemporaryCardCollectionEventModel> ActiveTemporaryCardCollectionEvents { get; }

        [MetaMember(281, (MetaMemberFlags)0)]
        public RandomPCG StackMiniGameRandom { get; set; }

        [MetaMember(282, (MetaMemberFlags)0)]
        public Dictionary<CollectibleBoardEventId, Queue<int>> PastPortalsGivenPerEvent { get; set; }

        [MetaMember(283, (MetaMemberFlags)0)]
        private MetaTime LastTimeZoneUpdateTimestamp { get; set; }

        [IgnoreDataMember]
        private MetaDuration MinTimeBetweenTimeZoneUpdate { get; }

        public static int CleanSessionDataAfterDays;
        [MetaMember(246, (MetaMemberFlags)0)]
        public HashSet<PlayerModeId> ActiveModesGlobal { get; set; }

        [MetaMember(288, (MetaMemberFlags)0)]
        public PlayerShortLeaderboardEventsModel ShortLeaderboardEvents { get; set; }

        [MetaMember(286, (MetaMemberFlags)0)]
        public ProgressionPackEventsModel ProgressionPackEvents { get; set; }

        [MetaMember(287, (MetaMemberFlags)0)]
        public Dictionary<MergeBoardId, HashSet<PlayerModeId>> ActiveModesPerBoard { get; set; }

        [IgnoreDataMember]
        public ShortLeaderboardEventDivisionClientState ShortLeaderboardEventDivisionClientState { get; }
        public IEnumerable<ProgressionPackEventModel> ActiveProgressionPackEvents { get; }
        public IEnumerable<ShortLeaderboardEventModel> ActiveShortLeaderboardEvents { get; }

        [MetaMember(289, (MetaMemberFlags)0)]
        public List<DigEventBoardId> CompletedShinyBoards { get; set; }

        [MetaMember(290, (MetaMemberFlags)0)]
        public DigEvent DigEvents { get; set; }

        [MetaMember(291, (MetaMemberFlags)0)]
        public RandomPCG DigEventRandom { get; set; }

        [MetaMember(292, (MetaMemberFlags)0)]
        public DigEventBoardId CurrentDigEventBoard { get; set; }

        [MetaMember(293, (MetaMemberFlags)0)]
        public DigEventMuseumModel DigEventMuseum { get; set; }

        [MetaMember(294, (MetaMemberFlags)0)]
        public int DigEventShinyBoardTries { get; set; }
        public IDigEventMinigameData DigEventMinigameData { get; set; }

        [MetaMember(296, (MetaMemberFlags)0)]
        public PlayerCardCollectionSupportingEventsModel CardCollectionSupportingEvents { get; set; }

        [MetaMember(297, (MetaMemberFlags)0)]
        public HashSet<EventLevelData> EventLevelsUpgradedByCardCollectionSupportingEvent { get; set; }
        public IEnumerable<CardCollectionSupportingEventModel> ActiveCardCollectionSupportingEvents { get; }

        [MetaMember(298, (MetaMemberFlags)0)]
        public Dictionary<string, ValueTuple<int, MetaTime>> AdsWatchLimiterTrack { get; set; }
        public IEnumerable<EnergyModeEventModel> ActiveEnergyModeEvents { get; }

        [IgnoreDataMember]
        public IMergeMansionGameConfig MergeMansionGameConfig { get; }

        [MetaMember(300, (MetaMemberFlags)0)]
        public Dictionary<LocationId, F64> CameraZoomPerLocation { get; set; }

        [MetaMember(301, (MetaMemberFlags)0)]
        public bool DebugUseAreaGlobalRequirement { get; set; }

        [MetaMember(302, (MetaMemberFlags)0)]
        public LocationId StartLocation { get; set; }

        [MetaMember(303, (MetaMemberFlags)0)]
        public PlayerCoreSupportEventsModel CoreSupportEvents { get; set; }

        [MetaMember(304, (MetaMemberFlags)0)]
        public PlayerMixABoosterEventsModel MixABoosterEvents { get; set; }

        [MetaMember(305, (MetaMemberFlags)0)]
        public int CurrentDigEventShinyProgressIndex { get; set; }
        public IEnumerable<CoreSupportEventModel> ActiveCoreSupportEvents { get; }

        [MetaMember(306, (MetaMemberFlags)0)]
        public PlayerAdStampCardEventModel AdStampCardEvents { get; set; }

        [MetaMember(307, (MetaMemberFlags)0)]
        public RandomPCG DigEventChanceRandom { get; set; }

        [IgnoreDataMember]
        public ClassicRacesEventDivisionClientState ClassicRacesEventDivisionClientState { get; }
        public IEnumerable<AdStampCardEventModel> ActiveAdStampCardEvents { get; }

        [MetaMember(308, (MetaMemberFlags)0)]
        [NoChecksum]
        public Dictionary<LocationId, F64Vec3> CameraPositionsPerLocation { get; set; }

        [IgnoreDataMember]
        public string SessionHandshakeDeviceModel { get; set; }

        [IgnoreDataMember]
        IMetacorePlayerTimeZoneInfo GameLogic.Player.IPlayer.TimeZoneInfo { get; }

        [MetaMember(248, (MetaMemberFlags)0)]
        [NoChecksum]
        [ServerOnly]
        [Obsolete]
        private PlayerBanInfo LegacyBanInfo { get; set; }

        [IgnoreDataMember]
        private ILastNSegmentsCache LastNSegmentsCache { get; set; }

        [IgnoreDataMember]
        ILastNSegmentsCache GameLogic.Player.IPlayer.LastNSegmentsCache { get; }

        [MetaMember(311, (MetaMemberFlags)0)]
        public TasksTabStyle? OverrideTasksTabStyle { get; set; }

        [IgnoreDataMember]
        public Option<TasksTabStyle> OverrideTasksTabStyleOption { get; }

        [MetaMember(312, (MetaMemberFlags)0)]
        public MetaTime? ScidWarningLastShownTime { get; set; }

        private static string GET_MERGE_BOARDS_ASSERT_MESSAGE;
        [MetaMember(313, (MetaMemberFlags)0)]
        public RandomPCG RollTheDiceRandom { get; set; }
        public IRollTheDiceMinigameData RollTheDiceMinigameData { get; set; }

        IRollTheDiceMinigameData GameLogic.Player.IPlayer.RollTheDiceMinigameData { get; }

        [MetaMember(315, (MetaMemberFlags)0)]
        public SegmentorState Segmentor { get; set; }
        public ICustomMergeBoardsState CustomMergeBoardsState { get; set; }

        ICustomMergeBoardsState GameLogic.Player.IPlayer.CustomMergeBoardsState { get; }
        public IEnumerable<MixABoosterEventModel> ActiveMixABoosterEvents { get; }

        private bool _modelEventsRegistered;
        [IgnoreDataMember]
        MetaTime GameLogic.Player.IPlayer.CurrentTime { get; }
    }
}