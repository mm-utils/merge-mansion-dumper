using Metaplay.Core.Model;

namespace GameLogic.StatsTracking
{
    [MetaSerializable]
    public enum StatsObjectiveType
    {
        Merge = 1,
        SpendResource = 2,
        UseProducer = 3,
        BurstBubbles = 4,
        CollectResource = 5,
        ClaimFromShop = 6,
        CompleteTasks = 7,
        OpenChests = 8,
        Invalid = 0,
        UseItems = 9,
        UseItemsFromChain = 10,
        EarnMysteryPassPoints = 11,
        CompleteNDailyTrades = 12,
        CompleteAllDailyTrades = 13,
        SpendCoreSupportEventToken = 14,
        EarnCoreSupportEventToken = 15,
        BuyFlashSales = 16,
        CompleteNCoreSupportEventMilestone = 17,
        CompleteNCollectibleBoardEventMilestone = 18,
        EarnBoultonLeagueEventPoints = 19,
        CollectCardPacksObjective = 20
    }
}