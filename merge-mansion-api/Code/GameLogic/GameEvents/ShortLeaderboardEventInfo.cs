using Metaplay.Core.Activables;
using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using System.Collections.Generic;
using Metaplay.Core;
using GameLogic.Player.Requirements;
using GameLogic.Player.Rewards;
using GameLogic.Story;
using Metaplay.Core.Math;
using GameLogic.Decorations;
using Merge;
using GameLogic.Config;
using Code.GameLogic.IAP;
using Metacore.MergeMansion.Common.Options;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    [MetaActivableConfigData("ShortLeaderboardEvent", false, true)]
    public class ShortLeaderboardEventInfo : IMetaActivableConfigData<ShortLeaderboardEventId>, IMetaActivableConfigData, IGameConfigData, IMetaActivableInfo, IGameConfigData<ShortLeaderboardEventId>, IHasGameConfigKey<ShortLeaderboardEventId>, IMetaActivableInfo<ShortLeaderboardEventId>, IBoardEventInfo, IHasRequirement, IEventSharedInfo, IBubbleBonusEvent, IValidatable
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public ShortLeaderboardEventId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string DisplayName { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public string Description { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaActivableParams ActivableParams { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public EventGroupId GroupId { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public int Priority { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public string NameLocalizationId { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public List<MetaRef<ShortLeaderboardEventStageInfo>> StageRefs { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public PlayerRequirement UnlockRequirement { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public MetaRef<RewardUpgradableInfo> FinalRewardRef { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public StoryDefinitionId IntroDialogue { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public StoryDefinitionId EndDialogue { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public bool DisableBubbleBonus { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public F32? BubbleBonusDivisor { get; set; }

        [MetaMember(15, (MetaMemberFlags)0)]
        public List<BubbleBonusInfo> SecondaryBoardBubbleBonus { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public PlayerRequirement PreviewRequirement { get; set; }
        public ShortLeaderboardEventId ActivableId { get; }
        public string DisplayShortInfo { get; }
        public MetaActivableTimelineSettings Timeline { get; }
        public IStringId BoardEventId { get; }
        public DecorationInfo ActiveDecoration { get; }
        public MergeBoardId MergeBoardId { get; }
        public ExtendableEventParams ExtendableEventParams { get; }
        public MetaRef<InAppProductInfo> ExtensionInAppProduct { get; }
        public MetaDuration ExtensionPurchaseSafetyMargin { get; }
        public string SharedEventId { get; }

        public ShortLeaderboardEventInfo()
        {
        }

        public ShortLeaderboardEventInfo(ShortLeaderboardEventId configKey, string displayName, string description, MetaActivableParams activableParams, EventGroupId groupId, int priority, string nameLocalizationId, List<MetaRef<ShortLeaderboardEventStageInfo>> stageRefs, PlayerRequirement unlockRequirement, MetaRef<RewardUpgradableInfo> finalRewardRef, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonus, PlayerRequirement previewRequirement)
        {
        }

        [MetaMember(17, (MetaMemberFlags)0)]
        public EventCategoryInfo CategoryInfo { get; set; }

        public ShortLeaderboardEventInfo(ShortLeaderboardEventId configKey, string displayName, string description, MetaActivableParams activableParams, EventGroupId groupId, int priority, string nameLocalizationId, List<MetaRef<ShortLeaderboardEventStageInfo>> stageRefs, PlayerRequirement unlockRequirement, MetaRef<RewardUpgradableInfo> finalRewardRef, StoryDefinitionId introDialogue, StoryDefinitionId endDialogue, bool disableBubbleBonus, F32? bubbleBonusDivisor, List<BubbleBonusInfo> secondaryBoardBubbleBonus, PlayerRequirement previewRequirement, EventCategoryInfo categoryInfo)
        {
        }

        public Option<EventGroupId> GroupIdOption { get; }
        public PlayerRequirement Requirement { get; }
    }
}