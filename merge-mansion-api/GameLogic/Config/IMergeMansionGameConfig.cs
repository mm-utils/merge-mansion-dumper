using Code.GameLogic.Area;
using Code.GameLogic.Config;
using Code.GameLogic.DynamicEvents;
using Code.GameLogic.ExtraSpawns;
using Code.GameLogic.FlashSales;
using Code.GameLogic.GameEvents;
using Code.GameLogic.GameEvents.CardCollectionSupportingEvent;
using Code.GameLogic.GameEvents.DailyChallenges.Data;
using Code.GameLogic.GameEvents.DailyScoop;
using Code.GameLogic.GameEvents.SoloMilestone;
using Code.GameLogic.Hotspots;
using Code.GameLogic.IAP;
using Code.GameLogic.Player.Requirements;
using Code.GameLogic.ProgressionTracks;
using Code.GameLogic.Social;
using Game.Cloud.Webshop;
using GameLogic.Addressables;
using GameLogic.Advertisement;
using GameLogic.Area;
using GameLogic.Audio;
using GameLogic.Banks;
using GameLogic.CardCollection;
using GameLogic.Codex;
using GameLogic.Config.DecorationShop;
using GameLogic.Config.EnergyModeEvent;
using GameLogic.Config.Map.Characters;
using GameLogic.Config.Shop;
using GameLogic.Cutscenes;
using GameLogic.DailyTasks;
using GameLogic.DailyTasksV2;
using GameLogic.Decorations;
using GameLogic.Dialogue;
using GameLogic.EventCharacters;
using GameLogic.Fallbacks;
using GameLogic.GameFeatures;
using GameLogic.Hotspots;
using GameLogic.Hotspots.CardStack;
using GameLogic.Inventory;
using GameLogic.ItemsInPocket;
using GameLogic.MergeChains;
using GameLogic.MiniEvents;
using GameLogic.MixABooster;
using GameLogic.Player;
using GameLogic.Player.Items;
using GameLogic.Player.Items.Bubble;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player.Items.GemMining;
using GameLogic.Player.Items.Merging;
using GameLogic.Player.Items.Order;
using GameLogic.Player.Items.OverrideSpawnChance;
using GameLogic.Player.Items.Sink;
using GameLogic.Player.Modes;
using GameLogic.Player.Rewards;
using GameLogic.Player.ScheduledActions;
using GameLogic.ProgressivePacks;
using GameLogic.Seasonality;
using GameLogic.Social;
using GameLogic.SocialMedia;
using GameLogic.Story;
using GameLogic.Story.SlideShows;
using GameLogic.Story.Videos;
using GameLogic.TaskLists;
using GameLogic.TieredOffers;
using Merge;
using Metacore;
using Metaplay.Core;
using Metaplay.Core.Config;
using Metaplay.Core.InAppPurchase;
using Metaplay.Core.Localization;
using Metaplay.Core.Math;
using Metaplay.Core.Offers;
using Metaplay.Core.Player;
using Player;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using TimedMergeBoards;

namespace GameLogic.Config
{
    public interface IMergeMansionGameConfig
    {
        IReadOnlyDictionary<int, ConfigLookupValue<ItemInPocketInfo>> ItemInPocketInfoByItemId { get; }

        SharedGlobals SharedGlobals { get; }

        IReadOnlyDictionary<HotspotId, IEnumerable<HotspotDefinition>> HotspotOpensAfterCompletion { get; }

        IReadOnlyDictionary<FlashSaleGroupId, ConfigLookupValue<FlashSaleGroupDefinition>> FlashSaleGroups { get; }

        CardCollectionSettings CardCollectionSettings { get; }

        IReadOnlyDictionary<int, CardCollectionPackId> CardPacksByItemId { get; }

        WebShopSettings WebShopSettings { get; }

        IReadOnlyDictionary<int, ConfigLookupValue<FallbackItemInfo>> FallbackItemInfoByItemId { get; }

        GameConfigLibrary<SharedProducerSettingsId, SharedProducerSettings> SharedProducerSettings { get; }

        GameConfigLibrary<InAppProductId, InAppProductInfo> InAppProducts { get; }

        GameConfigLibrary<int, ItemDefinition> Items { get; }

        GameConfigLibrary<CodexDiscoveryRewardId, CodexDiscoveryRewardInfo> CodexDiscoveryRewards { get; }

        GameConfigLibrary<CodexCategoryId, CodexCategoryInfo> CodexCategories { get; }

        GameConfigLibrary<ShopItemId, DynamicPurchaseDefinition> DynamicPurchaseProducts { get; }

        GameConfigLibrary<MergeBoardId, TimedMergeBoard> TimedMergeBoards { get; }

        GameConfigLibrary<AuthenticationPlatform, SocialAuthenticationConfig> SocialAuthentication { get; }

        GameConfigLibrary<GameFeatureId, GameFeatureSetting> GameFeatures { get; }

        GameConfigLibrary<MiniEventId, MiniEventInfo> MiniEvents { get; }

        GameConfigLibrary<MergeBoardId, BoardInfo> Boards { get; }

        //GameConfigLibrary<EventId, BoardEventInfo> BoardEvents { get; }

        GameConfigLibrary<EventId, ShopEventInfo> ShopEvents { get; }

        GameConfigLibrary<EventCurrencyId, EventCurrencyInfo> EventCurrencies { get; }

        GameConfigLibrary<EventLevelId, EventLevelInfo> EventLevels { get; }

        GameConfigLibrary<EventLevelSetId, EventLevels> LevelSets { get; }

        GameConfigLibrary<EventTaskId, EventTaskInfo> EventTasks { get; }

        GameConfigLibrary<EventOfferId, EventOfferInfo> EventOffers { get; }

        GameConfigLibrary<int, PlayerLevelData> PlayerLevels { get; }

        GameConfigLibrary<HotspotId, HotspotDefinition> HotspotDefinitions { get; }

        GameConfigLibrary<DecorationId, DecorationInfo> Decorations { get; }

        GameConfigLibrary<StoryDefinitionId, StoryElementInfo> StoryElements { get; }

        GameConfigLibrary<DialogItemId, DialogItemInfo> DialogItems { get; }

        GameConfigLibrary<MapCharacterEventId, MapCharacterEventDefinition> MapCharacterEvents { get; }

        GameConfigLibrary<ShopItemId, ShopItemInfo> ShopItems { get; }

        GameConfigLibrary<ShopItemId, FlashSaleDefinition> GarageFlashSales { get; }

        GameConfigLibrary<ShopItemId, FlashSaleDefinition> EventFlashSales { get; }

        GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> GarageFlashSaleGroups { get; }

        GameConfigLibrary<FlashSaleGroupId, FlashSaleGroupDefinition> EventFlashSaleGroups { get; }

        GameConfigLibrary<DigEventItemId, DigEventItemInfo> DigEventItemInfos { get; }

        GameConfigLibrary<DigEventBoardId, DigEventBoards> DigEventBoards { get; }

        GameConfigLibrary<DigEventMuseumShelfId, DigEventMuseumShelfInfo> DigEventShelves { get; }

        GameConfigLibrary<DigEventId, DigEventInfo> DigEvents { get; }

        GameConfigLibrary<DigEventShinyProgressionId, DigEventShinyProgression> DigEventShinyProgression { get; }

        GameConfigLibrary<GarageCleanupEventId, GarageCleanupEventInfo> GarageCleanupEvents { get; }

        GameConfigLibrary<GarageCleanupBoardRowId, GarageCleanupBoardRowInfo> GarageCleanupBoardRows { get; }

        GameConfigLibrary<GarageCleanupPatternSetId, GarageCleanupPatternSetInfo> GarageCleanupPatternSets { get; }

        GameConfigLibrary<GarageCleanupPatternRowId, GarageCleanupPatternRowInfo> GarageCleanupPatternRows { get; }

        GameConfigLibrary<GarageCleanupRewardId, GarageCleanupRewardInfo> GarageCleanupRewards { get; }

        GameConfigLibrary<InventorySlotId, InventorySlotsConfig> InventorySlots { get; }

        GameConfigLibrary<ProducerInventorySlotId, ProducerInventorySlotConfig> ProducerInventorySlots { get; }

        GameConfigLibrary<FlashSaleShopSettingsId, FlashSaleShopSettings> FlashSaleShopSettings { get; }

        GameConfigLibrary<ShopLayoutId, ShopLayout> ShopLayouts { get; }

        GameConfigLibrary<int, SuppressedBuildLogsInfo> SuppressedWarnings { get; }

        GameConfigLibrary<EventOfferSetId, EventOfferSetInfo> EventOfferSets { get; }

        GameConfigLibrary<OfferPopupTriggerId, OfferPopupTrigger> OfferPopupTriggers { get; }

        GameConfigLibrary<MetaOfferId, DelayedOfferPurchaseRequirement> DelayedOfferPurchaseRequirements { get; }

        GameConfigLibrary<AddressablesDownloadProcessId, AddressablesDownloadProcess> AddressablesDownloadProcesses { get; }

        GameConfigLibrary<CollectibleDialoguesInfoId, CollectibleDialoguesInfo> CollectibleDialoguesInfo { get; }

        GameConfigLibrary<LevelUpTutorialConfigId, LevelUpTutorialConfig> LevelUpTutorialConfig { get; }

        GameConfigLibrary<ScheduledActionId, ScheduledActionInfo> ScheduledActions { get; }

        GameConfigLibrary<CollectibleBoardEventId, CollectibleBoardEventInfo> CollectibleBoardEvents { get; }

        GameConfigLibrary<LeaderboardEventId, LeaderboardEventInfo> LeaderboardEvents { get; }

        GameConfigLibrary<SideBoardEventId, SideBoardEventInfo> SideBoardEvents { get; }

        GameConfigLibrary<BoultonLeagueEventId, BoultonLeagueEventInfo> BoultonLeagueEvents { get; }

        GameConfigLibrary<BoultonLeagueStageId, BoultonLeagueStageInfo> BoultonLeagueStages { get; }

        GameConfigLibrary<DialogCharacterType, DialogueCharacterInfo> DialogueCharacters { get; }

        GameConfigLibrary<EventCharacterId, EventCharacterInfo> EventCharacters { get; }

        GameConfigLibrary<SocialAuthRewardId, SocialAuthRewardInfo> SocialAuthRewards { get; }

        GameConfigLibrary<ReEngagementSettingsId, ReEngagementSettings> ReEngagementSettings { get; }

        GameConfigLibrary<CutsceneId, CutsceneInfo> Cutscenes { get; }

        GameConfigLibrary<LayeredDecorationSetId, LayeredDecorationSetInfo> LayeredDecorations { get; }

        GameConfigLibrary<ProgressionPackId, ProgressionPack> ProgressionPacks { get; }

        GameConfigLibrary<MetaOfferId, MakeYourOwnOfferInfo> MakeYourOwnOffers { get; }

        GameConfigLibrary<MapSpotId, MapSpotInfo> MapSpots { get; }

        FishingSettings FishingSettings { get; }

        GemSettings GemSettings { get; }

        GameConfigLibrary<ProgressionEventStreakId, ProgressionEventStreakRewards> ProgressionEventStreaks { get; }

        GameConfigLibrary<SeasonId, SeasonInfo> Seasons { get; }

        GameConfigLibrary<MergeChainId, MergeChainDefinition> MergeChains { get; }

        GameConfigLibrary<CardCollectionCardId, CardCollectionCardInfo> CardCollectionCardInfos { get; }

        GameConfigLibrary<CardCollectionCardSetId, CardCollectionCardSetInfo> CardCollectionCardSetInfos { get; }

        GameConfigLibrary<CardCollectionPackId, CardCollectionPackInfo> CardCollectionPackInfos { get; }

        GameConfigLibrary<CardCollectionCardActivationId, CardCollectionCardActivationInfo> CardCollectionCardActivationInfos { get; }

        GameConfigLibrary<CardCollectionPackActivationId, CardCollectionPackActivationInfo> CardCollectionPackActivationInfos { get; }

        GameConfigLibrary<CardCollectionHiddenRarityActivationId, CardCollectionHiddenRarityActivationInfo> CardCollectionHiddenRarityActivationInfos { get; }

        GameConfigLibrary<CardCollectionSetActivationId, CardCollectionSetActivationInfo> CardCollectionSetActivationInfos { get; }

        GameConfigLibrary<CardCollectionBalanceId, CardCollectionBalanceInfo> CardCollectionBalanceInfos { get; }

        GameConfigLibrary<CardCollectionEvidenceBoxId, CardCollectionEvidenceBoxInfo> CardCollectionEvidenceBoxes { get; }

        GameConfigLibrary<CardCollectionDuplicateRewardId, CardCollectionDuplicateRewardInfo> CardCollectionDuplicateCardRewards { get; }

        GameConfigLibrary<CardCollectionSupportingEventId, CardCollectionSupportingEventInfo> CardCollectionSupportingEvents { get; }

        GameConfigLibrary<CardCollectionPackId, CardCollectionSupportingEventReplacementPackInfo> CardCollectionSupportingEventsReplacementPacks { get; }

        GameConfigLibrary<CardStackId, CardStackInfo> CardStacks { get; }

        GameConfigLibrary<ProgressionEventId, ProgressionEventInfo> ProgressionEvents { get; }

        GameConfigLibrary<MetaOfferGroupId, MergeMansionOfferGroupInfo> OfferGroups { get; }

        GameConfigLibrary<PlayerSegmentId, PlayerSegmentInfo> PlayerSegments { get; }

        GameConfigLibrary<FallbackPlayerRewardId, FallbackPlayerRewardInfo> FallbackPlayerRewards { get; }

        GameConfigLibrary<MetaOfferId, MergeMansionOfferInfo> Offers { get; }

        GameConfigLibrary<TemporaryCardCollectionEventId, TemporaryCardCollectionEventInfo> TemporaryCardCollectionEvents { get; }

        GameConfigLibrary<ShortLeaderboardEventId, ShortLeaderboardEventInfo> ShortLeaderboardEvents { get; }

        GameConfigLibrary<CurrencyBankId, CurrencyBankInfo> CurrencyBanks { get; }

        GameConfigLibrary<AreaId, AreaInfo> Areas { get; }

        GameConfigLibrary<MergeRewardId, MergeReward> XpMergeRewards { get; }

        GameConfigLibrary<SocialMediaId, SocialMediaInfo> SocialMedia { get; }

        GameConfigLibrary<RewardContainerId, RewardContainerInfo> RewardContainers { get; }

        GameConfigLibrary<MysteryMachineId, MysteryMachineInfo> MysteryMachines { get; }

        GameConfigLibrary<int, EnergyModeProgressionEventItemInfo> EnergyModeProgressionEventItems { get; }

        GameConfigLibrary<MysteryMachineEventId, MysteryMachineEventInfo> MysteryMachineEvents { get; }

        GameConfigLibrary<PlayerModeId, EnergyModeInfo> EnergyModes { get; }

        GameConfigLibrary<MergeChainId, DailyTasksV2MergeChainInfo> DailyTasksV2MergeChains { get; }

        GameConfigLibrary<MysteryMachineLeaderboardConfigId, MysteryMachineLeaderboardConfigInfo> MysteryMachineLeaderboardConfigs { get; }

        GameConfigLibrary<PetId, PetInfo> PetInfos { get; }

        GameConfigLibrary<LocationTravelId, LocationTravelInfo> LocationTravels { get; }

        GameConfigLibrary<SoloMilestoneEventId, SoloMilestoneEventInfo> SoloMilestoneEvents { get; }

        GameConfigLibrary<DailyScoopEventId, DailyScoopEventInfo> DailyScoopEvents { get; }

        IReadOnlyDictionary<int, CardCollectionCardId> InformantTipsByItemId { get; }

        IReadOnlyDictionary<MergeBoardId, List<CollectibleBoardEventId>> CollectibleBoardEventBoards { get; }

        IReadOnlyDictionary<ValueTuple<CardStars, TemporaryCardCollectionEventId>, DuplicateRewardPair> DuplicateRewards { get; }

        IReadOnlyDictionary<DecorationShopItemId, List<PlayerSegmentId>> DecorationShopItemSegments { get; }

        IReadOnlyDictionary<int, IReadOnlyList<ValueTuple<ConfigLookupValue<ItemDefinition>, F32>>> ItemProducingParents { get; }

        IReadOnlyDictionary<MergeBoardId, LeaderboardEventId> LeaderboardEventBoards { get; }

        int MaxPlayerLevel { get; }

        IReadOnlyDictionary<MysteryMachineLeaderboardConfigId, IImmutableSet<PlayerSegmentId>> MysteryMachineLeaderboardRewardSegments { get; }

        IReadOnlyList<int> MysteryMachineItemIds { get; }

        DailyTasksV2Settings DailyTasksV2Settings { get; }

        IReadOnlyDictionary<OfferPlacementId, List<MetaOfferGroupId>> OfferGroupIdsByOfferPlacementId { get; }

        IReadOnlyDictionary<MergeBoardId, List<CollectibleBoardEventId>> TheGreatEscapeEventBoards { get; }

        IReadOnlyDictionary<MergeBoardId, List<CollectibleBoardEventId>> DigEventMergeBoards { get; }

        IReadOnlyList<ConfigLookupValue<TemporaryCardCollectionEventInfo>> OrderedTemporaryCardCollectionEventInfos { get; }

        IReadOnlyDictionary<CollectibleBoardEventId, MergeBoardId> FishingEventBoards { get; }

        IReadOnlyDictionary<MergeBoardId, List<CollectibleBoardEventId>> GemMineEventBoards { get; }

        IReadOnlyDictionary<MergeBoardId, List<IStringId>> EventsByMergeBoard { get; }

        IImmutableSet<int> CardItems { get; }

        IReadOnlyList<IReadOnlyList<int>> ProducerVariants { get; }

        IImmutableSet<int> CardDeckItems { get; }

        IReadOnlyList<HotspotId> AreaUnlockHotspots { get; }

        IReadOnlyDictionary<MergeBoardId, MysteryMachineEventId> MysteryMachineEventBoards { get; }

        IImmutableSet<MergeBoardId> AuxEnergyMergeBoards { get; }

        IReadOnlyList<PortalPieceChainData> PortalPieceChains { get; }

        IReadOnlyDictionary<MergeBoardId, SideBoardEventId> SideBoardEventBoards { get; }

        RestoreCountryCodeSettings RestoreCountryCodeSettings { get; }

        IReadOnlyDictionary<DialogItemId, List<DialogCharacterType>> CharactersToForceDiscoverByNonHotspotDialogItemId { get; }

        IImmutableSet<int> ItemsAcceptedBySinks { get; }

        IReadOnlyDictionary<OfferPlacementId, List<OfferPlacementId>> OfferPlacementIds { get; }

        IReadOnlyDictionary<MergeBoardId, EventId> BoardEventBoards { get; }

        IImmutableSet<MergeBoardId> ShortLeaderboardEventBoards { get; }

        IReadOnlyDictionary<LeaderboardEventId, List<ConfigLookupValue<MergeChainDefinition>>> MergeChainsByLeaderboardEventId { get; }

        IReadOnlyCollection<ConfigLookupValue<IItemDefinition>> ItemsAvailableOnlyDuringCardCollectionEvent { get; }

        GameConfigLibrary<MixABoosterEventId, MixABoosterEventInfo> MixABoosterEvents { get; }

        GameConfigLibrary<MixABoosterRecipeId, MixABoosterRecipe> MixABoosterRecipes { get; }

        GameConfigLibrary<MixABoosterIngredientId, MixABoosterIngredient> MixABoosterIngredients { get; }

        GameConfigLibrary<EventTaskId, EventTaskInfo> DynamicEventTasks { get; }

        GameConfigLibrary<AdStampCardEventId, AdStampCardEventInfo> AdStampCardEvents { get; }

        IReadOnlyDictionary<ConfigLookupValue<ItemDefinition>, IOverrideSpawnChanceFeatures> OverrideSpawnChanceByItemDefinition { get; }

        IReadOnlyList<ConfigLookupValue<ItemDefinition>> FishItems { get; }

        IReadOnlyList<ConfigLookupValue<ItemDefinition>> FishingRodItems { get; }

        IReadOnlyList<ConfigLookupValue<ItemDefinition>> CutGemItems { get; }

        IReadOnlyList<ConfigLookupValue<ItemDefinition>> PrisonerLetterItems { get; }

        IReadOnlyList<ConfigLookupValue<ItemDefinition>> PrisonBadgeItems { get; }

        GameConfigLibrary<int, ExtraSpawnItemValueInfo> ExtraSpawnItemValues { get; }

        GameConfigLibrary<Currencies, ExtraSpawnCurrencyValueInfo> ExtraSpawnCurrencyValues { get; }

        GameConfigLibrary<EnergyModeEventId, EnergyModeEventInfo> EnergyModeEvents { get; }

        GameConfigLibrary<DecorationShopId, DecorationShopInfo> DecorationShops { get; }

        GameConfigLibrary<DailyTaskId, DailyTaskDefinition> DailyTasks { get; }

        GameConfigLibrary<AdvertisementPlacementId, AdvertisementPlacementsInfo> AdvertisementPlacements { get; }

        GameConfigLibrary<MysteryMachineSpecialSaleId, MysteryMachineSpecialSaleInfo> MysteryMachineSpecialSales { get; }

        GameConfigLibrary<BubblesSetupId, BubblesSetup> BubbleSetups { get; }

        GameConfigLibrary<ProgressionPackEventId, ProgressionPackEventInfo> ProgressionPackEvents { get; }

        GameConfigLibrary<CoreSupportEventId, CoreSupportEventInfo> CoreSupportEvents { get; }

        GameConfigLibrary<MysteryMachineCurrencyItemChainId, MysteryMachineCurrencyItemChainInfo> MysteryMachineCurrencyItemChains { get; }

        GameConfigLibrary<MysteryMachineCurrencyItemId, MysteryMachineCurrencyItemInfo> MysteryMachineCurrencyItems { get; }

        GameConfigLibrary<MysteryMachineExtraItemGrantingId, MysteryMachineExtraItemGrantingInfo> MysteryMachineExtraItemGranting { get; }

        GameConfigLibrary<MysteryMachineChainMultiplierId, MysteryMachineChainMultiplierInfo> MysteryMachineChainMultipliers { get; }

        GameConfigLibrary<MysteryMachineItemScoreId, MysteryMachineItemScore> MysteryMachineItemScores { get; }

        GameConfigLibrary<MysteryMachineSpecialItemItemId, MysteryMachineSpecialItemInfo> MysteryMachineSpecialItems { get; }

        GameConfigLibrary<MysteryMachineProgressionEventProgressItemChainId, MysteryMachineProgressionEventProgressItemChainInfo> MysteryMachineProgressionEventProgressItemChains { get; }

        GameConfigLibrary<ItemTypeConstant, DailyTasksV2ItemBoultonLeagueInfo> DailyTasksV2ItemsBoultonLeague { get; }

        GameConfigLibrary<DailyScoopDayId, DailyScoopDayData> DailyScoopDays { get; }

        GameConfigLibrary<DailyScoopWeekId, DailyScoopWeekData> DailyScoopWeeks { get; }

        GameConfigLibrary<DailyScoopMilestoneId, DailyScoopMilestoneData> DailyScoopMilestones { get; }

        GameConfigLibrary<DailyScoopSpecialObjectiveId, DailyScoopSpecialObjectiveData> DailyScoopSpecialObjectives { get; }

        GameConfigLibrary<DailyScoopStandardObjectiveId, DailyScoopStandardObjectiveData> DailyScoopStandardObjectives { get; }

        GameConfigLibrary<DynamicEventRewardId, DynamicEventRewardInfo> DynamicEventRewards { get; }

        GameConfigLibrary<SoloMilestoneTokenSpawnsId, SoloMilestoneTokenSpawnsInfo> SoloMilestoneTokenSpawns { get; }

        GameConfigLibrary<DynamicEventItemId, DynamicEventItemInfo> DynamicEventItems { get; }

        GameConfigLibrary<ShortLeaderboardEventStageId, ShortLeaderboardEventStageInfo> ShortLeaderboardEventStages { get; }

        GameConfigLibrary<DailyTaskV2Id, DailyTaskV2BoultonLeagueInfo> DailyTasksV2BoultonLeague { get; }

        GameConfigLibrary<EnergyType, EnergySettingsConfig> EnergySettings { get; }

        GameConfigLibrary<TaskListId, TaskListInfo> TaskLists { get; }

        GameConfigLibrary<DailyTaskV2Id, DailyTaskV2Info> DailyTasksV2 { get; }

        GameConfigLibrary<AreasGlobalUnlockRequirementId, AreasGlobalUnlockRequirementInfo> AreasGlobalUnlockRequirements { get; }

        GameConfigLibrary<SoloMilestoneMilestonesId, SoloMilestoneMilestonesInfo> SoloMilestoneMilestones { get; }

        GameConfigLibrary<DynamicEventHelperId, DynamicEventHelperInfo> DynamicEventHelpers { get; }

        GameConfigLibrary<DailyTaskV2Id, DailyTaskV2BoultonLeagueUnlimitedInfo> DailyTasksV2BoultonLeagueUnlimited { get; }

        GameConfigLibrary<RentableInventorySettingsId, RentableInventorySettings> RentableInventorySettings { get; }

        GameConfigLibrary<TaskGroupId, TaskGroupDefinition> TaskGroups { get; }

        GameConfigLibrary<DigEventMuseumCollectionId, DigEventMuseumCollectionInfo> DigEventMuseumCollections { get; }

        GameConfigLibrary<DecorationShopItemId, DecorationShopItemInfo> DecorationShopItems { get; }

        GameConfigLibrary<MysteryMachineItemId, MysteryMachineItemInfo> MysteryMachineItems { get; }

        GameConfigLibrary<MysteryMachineItemSetId, MysteryMachineItemSetInfo> MysteryMachineItemSets { get; }

        GameConfigLibrary<MysteryMachineMultiplierId, MysteryMachineMultiplierInfo> MysteryMachineMultipliers { get; }

        GameConfigLibrary<string, ExtraSpawnInfo> ExtraSpawns { get; }

        GameConfigLibrary<BubbleVariationId, BubbleVariantsDefinition> BubbleVariations { get; }

        GameConfigLibrary<OrderRequirementsId, OrderRequirements> OrderRequirements { get; }

        GameConfigLibrary<string, TagRewardsInfo> TagRewards { get; }

        //GameConfigLibrary<TheGreatEscapeMinigameId, TheGreatEscapeMinigameInfo> TheGreatEscapeMinigames { get; }

        GameConfigLibrary<string, MMPlaylist> Playlists { get; }

        GameConfigLibrary<VideoId, Video> Videos { get; }

        GameConfigLibrary<SlideShowId, SlideShow> SlideShows { get; }

        GameConfigLibrary<LanguageId, LanguageInfo> Languages { get; }

        GameConfigLibrary<CustomHotspotTableId, CustomHotspotTablesInfo> CustomTables { get; }

        GameConfigLibrary<CoreSupportEventMinigameId, ClassicRacesMinigameInfo> ClassicRacesMinigames { get; }

        GameConfigLibrary<ClassicRacesEventStageId, ClassicRacesEventStageInfo> ClassicRacesEventStages { get; }

        GameConfigLibrary<OfferPlacementId, List<MetaOfferGroupInfoBase>> MetaOfferGroupsPerPlacementInMostImportantFirstOrder { get; }

        GameConfigLibrary<ExtraSpawnTriggerType, HashSet<CoreSupportEventTokenId>> ExtraSpawnTriggerCoreSupportEventTokens { get; }

        IReadOnlyList<InAppProductId> ProgressionEventIAPs { get; }

        ILastNSegmentsConfig LastNSegmentsConfig { get; }

        AutoMergeSettings AutoMergeSettings { get; }

        Dictionary<ProgressionTrackId, ProgressionTrackInfo> ProgressionTracks { get; }

        IRollTheDiceConfig RollTheDiceConfig { get; }

        Dictionary<RequirementId, RequirementInfo> Requirements { get; }

        Dictionary<LocationId, LocationInfo> Locations { get; }

        Dictionary<MergeBoardId, List<HotspotId>> OpenMergeBoardHotspotsByMergeBoard { get; }

        IDailyChallengesEventConfig DailyChallengesEventConfig { get; }

        List<InAppProductId> CurrencyBankIAPs { get; }

        IBuilderEventConfig BuilderEventConfig { get; }
    }
}