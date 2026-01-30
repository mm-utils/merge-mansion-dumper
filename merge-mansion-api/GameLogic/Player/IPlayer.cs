using System.Collections.Generic;
using Game.Logic;
using GameLogic.Player.Board;
using GameLogic.Random;
using Metaplay.Core.Session;
using System;
using GameLogic.Player.DailyTasks;
using GameLogic.GameFeatures;
using Metaplay.Core;
using Metaplay.Core.Player;
using GameLogic.Offers;
using GameLogic.Player.Modifiers;
using Game.Logic.Mail;
using Code.GameLogic.GameEvents;
using GameLogic.Banks;
using GameLogic.Player.Director.Actions;
using GameLogic.Player.Director.Conditions;
using GameLogic.Player.Modes;
using Code.GameLogic.DynamicEvents;
using GameLogic.Player.DailyTasksV2;
using System.Runtime.CompilerServices;
using GameLogic.Config.EnergyModeEvent;
using GameLogic.Player.Events;
using GameLogic.MiniEvents;
using Code.GameLogic.Player.Events.DailyScoopEvent;
using GameLogic.Player.Items;
using Merge;
using Code.GameLogic.GameEvents.CardCollectionSupportingEvent;
using Metaplay.Core.Math;
using GameLogic.Player.Leaderboard.ShortLeaderboardEvent;
using Code.GameLogic.Player.Board;
using Code.GameLogic.Player;
using GameLogic.Player.Leaderboard.ClassicRacesEvent;
using GameLogic.Config.Types;
using Metacore.MergeMansion.Common.Options;
using Code.GameLogic.Config;

namespace GameLogic.Player
{
    public interface IPlayer : IGenerationContext
    {
        SpawnFactoryState SpawnFactoryState { get; }

        IEnumerable<IBoard> Boards { get; }

        PlayerIdentity PlayerIdentity { get; }

        SessionToken SessionToken { get; }

        int LogicVersion { get; }

        int PlayerLevel { get; }

        Wallet Wallet { get; }

        ProgressState ProgressState { get; }

        DailyTaskStatus DailyTaskStatus { get; }

        StoreStatus StoreStatus { get; }

        GameSettings GameSettings { get; }

        GameFeaturesStates UnlockedFeatures { get; }

        MetaTime CurrentTime { get; }

        PlayerLocalTime CurrentLocalTime { get; }

        IEnumerable<IActiveOfferGroup> ActiveOfferGroups { get; }

        IEnumerable<IPlayerModifier> ActiveModifiers { get; }

        LogChannel Log { get; }

        IPlayerModelClientListener ClientListener { get; }

        IPlayerModelServerListener ServerListener { get; }

        IEnumerable<ValueTuple<IBoard, MetaTime?>> BoardsWithExpirationTimes { get; }

        IEnumerable<IMailMessage> MailMessages { get; }

        IEnumerable<GarageCleanupEventModel> ActiveGarageCleanups { get; }

        IEnumerable<BoardEventModel> ActiveBoardEvents { get; }

        IEnumerable<CollectibleBoardEventModel> ActiveCollectibleBoardEvents { get; }

        IEnumerable<LeaderboardEventModel> ActiveLeaderboardEvents { get; }

        IEnumerable<ShopEventModel> ActiveShopEvents { get; }

        IEnumerable<ProgressionEventModel> ActiveProgressionEvents { get; }

        PlayerProgressionEventsModel ProgressionEvents { get; }

        PlayerCollectibleBoardEventsModel CollectibleBoardEvents { get; }

        CurrencyBanksModel CurrencyBanksModel { get; }

        CurrencyBankModel CurrencyBankModel { get; }

        string PlayerName { get; }

        ValueTuple<IBoardInventory, MetaTime?> RentableInventory { get; }

        int ProgressionEventIAPStreakLength { get; }

        IBoardInventory GarageBoardInventory { get; }

        IBoardInventory GarageBoardProducerInventory { get; }

        DynamicEventTaskStatus DynamicEventTaskStatus { get; }

        PlayerModifiersChangedEvent ModifiersChanged { get; set; }

        PlayerModesChangedEvent ModesChanged { get; set; }

        OverrideSpawnItemsStatus OverrideSpawnItemsStatus { get; }

        IEnumerable<SideBoardEventModel> ActiveSideBoardEvents { get; }

        Dictionary<int, RandomPCG> RandomsByFishingRodType { get; set; }

        List<IPlayerModifier> ActiveModifiersNonAlloc { get; }

        IEnumerable<GarageCleanupEventModel> AllGarageCleanups { get; }

        IEnumerable<SideBoardEventModel> AllSideBoardEvents { get; }

        IEnumerable<MysteryMachineEventModel> ActiveMysteryMachineEvents { get; }

        RandomPCG MysteryMachineRandom { get; }

        List<IWritableProducerInventorySlotState> ProducerInventoryEntries { get; }

        DailyTasksV2Status DailyTasksV2Status { get; }

        PlayerEnergyModeEventsModel EnergyModeEvents { get; }

        IEnumerable<SoloMilestoneEventModel> ActiveSoloMilestoneEvents { get; }

        IEnumerable<MiniEventModel> ActiveMiniEvents { get; }

        PlayerBoardEventsModel BoardEvents { get; }

        PlayerLeaderboardEventsModel LeaderboardEvents { get; }

        PlayerMysteryMachineEventsModel MysteryMachineEvents { get; }

        RandomPCG SoloMilestoneRandom { get; }

        PlayerMiniEventOverrides MiniEventOverrides { get; }

        IEnumerable<DailyScoopEventModel> ActiveDailyScoopEvents { get; }

        Dictionary<string, Coordinate> BubblesWithAds { get; }

        BoultonLeagueStatus BoultonLeagueStatus { get; }

        IEnumerable<TemporaryCardCollectionEventModel> ActiveTemporaryCardCollectionEvents { get; }

        RandomPCG RewardContainerRandom { get; }

        RandomPCG StackMiniGameRandom { get; }

        HashSet<PlayerModeId> ActiveModesGlobal { get; }

        Dictionary<MergeBoardId, HashSet<PlayerModeId>> ActiveModesPerBoard { get; }

        IEnumerable<ShortLeaderboardEventModel> ActiveShortLeaderboardEvents { get; }

        ProgressionPackEventsModel ProgressionPackEvents { get; }

        PlayerShortLeaderboardEventsModel ShortLeaderboardEvents { get; }

        IEnumerable<CardCollectionSupportingEventModel> ActiveCardCollectionSupportingEvents { get; }

        HashSet<EventLevelData> EventLevelsUpgradedByCardCollectionSupportingEvent { get; }

        PlayerCardCollectionSupportingEventsModel CardCollectionSupportingEvents { get; }

        SortedDictionary<int, F64> MoneySpentPerDay { get; }

        RandomPCG DigEventRandom { get; }

        MergeBoardId ActiveMergeBoardId { get; }

        IEnumerable<EnergyModeEventModel> ActiveEnergyModeEvents { get; }

        Dictionary<string, ValueTuple<int, MetaTime>> AdsWatchLimiterTrack { get; }

        IEnumerable<CoreSupportEventModel> ActiveCoreSupportEvents { get; }

        PlayerCoreSupportEventsModel CoreSupportEvents { get; }

        DigEventBoardId CurrentDigEventBoard { get; set; }

        IDigEventMinigameData DigEventMinigameData { get; }

        DigEventMuseumModel DigEventMuseum { get; }

        IBoardInventory RentableBoardInventory { get; }

        F64 TotalIapSpend { get; }

        ShortLeaderboardEventDivisionClientState ShortLeaderboardEventDivisionClientState { get; }

        ClassicRacesEventDivisionClientState ClassicRacesEventDivisionClientState { get; }

        IMetacorePlayerTimeZoneInfo TimeZoneInfo { get; }

        ILastNSegmentsCache LastNSegmentsCache { get; }

        Option<TasksTabStyle> OverrideTasksTabStyleOption { get; }

        public static int MaxMergeBoards;
        public static int MaxInventories;
        RandomPCG RollTheDiceRandom { get; }

        IRollTheDiceMinigameData RollTheDiceMinigameData { get; }

        SegmentorState Segmentor { get; }

        bool IsProductionEnvironment { get; }

        bool IsDeveloper { get; }

        ICustomMergeBoardsState CustomMergeBoardsState { get; }

        LocationId StartLocation { get; }

        MergeBoard GarageMergeBoard { get; }
    // Slot: 50
    //void AddScriptedEvent(IScriptedEventCondition condition, ISerializedAction action);
    }
}