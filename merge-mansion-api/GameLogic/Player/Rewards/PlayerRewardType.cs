using Metaplay.Core.Model;

namespace GameLogic.Player.Rewards
{
    [MetaSerializable]
    [ForceExplicitEnumValues]
    public enum PlayerRewardType
    {
        None = 0,
        Currency = 1,
        DailyScoopPoints = 2,
        Item = 3,
        EventCurrency = 4,
        EventPoints = 5,
        Decoration = 6,
        LayeredDecoration = 7,
        GameEventTimeExtension = 8,
        ProgressionEventPoints = 9,
        ProgressionEventPremium = 10,
        ProgressionEventPerk = 11,
        LevelUpMergeChain = 12,
        CollectibleBoardEventProgress = 13,
        SideBoardEventProgress = 14,
        EventCharacter = 15,
        ActivateInfiniteEnergy = 16,
        SkipTime = 17,
        Pet = 18,
        CooldownRemover = 19,
        MysteryMachineEventProgress = 20,
        MysteryMachineIncreaseBaseScoreMultiplier = 21,
        MysteryMachineLevelUp = 22,
        Offer = 23,
        CardCollectionPack = 24,
        CardCollectionInformantTip = 25,
        BoultonLeaguePoints = 26,
        RewardContainer = 27,
        ItemForCollectibleBoardEvent = 28,
        Empty = 29,
        OnFire = 30,
        StartingValues = 31,
        CoreSupportEventToken = 31
    }
}