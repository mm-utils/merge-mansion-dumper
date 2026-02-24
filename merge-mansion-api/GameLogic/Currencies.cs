using Metaplay.Core.Json;
using System;
using System.ComponentModel;
using Metaplay.Core.Model;

namespace GameLogic
{
    [MetaSerializable]
    public enum Currencies
    {
        None = 0,
        Coins = 1,
        Experience = 2,
        Diamonds = 3,
        [Obsolete]
        Screws = 4,
        Energy = 5,
        EventCurrency = 6,
        SecondaryEnergy = 7,
        TertiaryEnergy = 8,
        ZeroEnergyCost = 9,
        SideBoardEventResourceItem = 10,
        MysteryMachineEnergy = 11,
        MysteryMachineCoins = 12,
        SoloMilestoneBaseToken = 13,
        InfiniteEnergy = 14,
        QuaternaryEnergy = 15,
        CardCollectionStars = 16,
        DigEventTaps = 17,
        ProgressionEventPoints = 18,
        WildItems = 19
    }
}