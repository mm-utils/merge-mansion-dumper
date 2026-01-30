using Code.GameLogic.Config;
using Metaplay.Core.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Config;
using Metaplay.Core.Schedule;
using GameLogic.Story;
using Metaplay.Core.Offers;
using GameLogic.Decorations;
using GameLogic.Cutscenes;
using Metaplay.Core.Math;
using GameLogic.MergeChains;
using Metaplay.Core.Player;
using Code.GameLogic.IAP;
using Code.GameLogic.ProgressionTracks;

namespace Code.GameLogic.GameEvents
{
    public class CollectibleBoardEventSource : IConfigItemSource<CollectibleBoardEventInfo, CollectibleBoardEventId>, IGameConfigSourceItem<CollectibleBoardEventId, CollectibleBoardEventInfo>, IHasGameConfigKey<CollectibleBoardEventId>
    {
        private CollectibleBoardEventId EventId { get; set; }
        private string NameLocId { get; set; }
        private string DisplayName { get; set; }
        private string Description { get; set; }
        private List<MetaRef<PlayerSegmentInfo>> Segments { get; set; }
        private bool IsEnabled { get; set; }
        private MetaScheduleBase Schedule { get; set; }
        private List<MetaRef<BoardInfo>> Board { get; set; }
        private string PortalItem { get; set; }
        private List<MetaRef<EventLevelInfo>> Levels { get; set; }
        private List<MetaRef<EventLevelInfo>> RecurringLevels { get; set; }
        private string FallbackLevels { get; set; }
        private StoryDefinitionId EnterBoardDialogue { get; set; }
        private List<OfferPlacementId> BoardShopPlacementId { get; set; }
        private StoryDefinitionId EndDialogue { get; set; }
        private DecorationId ActiveDecoration { get; set; }
        private List<int> ProgressionPopupHeaderImageLevels { get; set; }
        private string EventInitTask { get; set; }
        private string EventTasks { get; set; }
        private StoryDefinitionId StartDialogue { get; set; }
        private CutsceneId StartCutscene { get; set; }
        private string PreviewRequirementType { get; set; }
        private string PreviewRequirementId { get; set; }
        private string PreviewRequirementAmount { get; set; }
        private string PreviewRequirementAux0 { get; set; }
        private string UnlockRequirementType { get; set; }
        private string UnlockRequirementId { get; set; }
        private string UnlockRequirementAmount { get; set; }
        private string UnlockRequirementAux0 { get; set; }
        private int MaxExtensions { get; set; }
        private MetaDuration ExtensionDuration { get; set; }
        private MetaDuration ExtensionReviewDuration { get; set; }
        private MetaRef<InAppProductInfo> ExtensionInAppProduct { get; set; }
        private MetaDuration ExtensionPurchaseSafetyMargin { get; set; }
        private List<string> ExtensionRewardType { get; set; }
        private List<string> ExtensionRewardId { get; set; }
        private List<int> ExtensionRewardAmount { get; set; }
        private List<string> ExtensionRewardAux0 { get; set; }
        private List<string> ExtensionRewardAux1 { get; set; }
        private EventGroupId GroupId { get; set; }
        private MetaDuration? AuxEnergyUnitRestoreDuration { get; set; }
        private int AuxEnergyAttachmentChance { get; set; }
        private bool DisableBubbleBonus { get; set; }
        private F32? BubbleBonusDivisor { get; set; }
        private List<int> SecondaryBoardDivisorEnergyType { get; set; }
        private List<F32> SecondaryBoardBubbleDivisorOverride { get; set; }
        private List<bool> SecondaryBoardBubbleDivisorEnabled { get; set; }
        public CollectibleBoardEventId ConfigKey { get; }

        public CollectibleBoardEventSource()
        {
        }

        private bool ShouldReset { get; set; }
        private MergeChainId PersistingChainID { get; set; }
        private LuckyType LuckyType { get; set; }
        private int Priority { get; set; }
        private string ContextCategory { get; set; }
        private string ContextSubCategory { get; set; }
        private string ConnectedMinigameId { get; set; }
        private string PrefabsOverride { get; set; }
        private bool ForceLocationTravel { get; set; }
        private List<ProgressionTrackId> EventProgressionTracks { get; set; }
    }
}