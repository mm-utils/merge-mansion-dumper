using Metaplay.Core.Model;

namespace GameLogic
{
    [MetaSerializable]
    public enum NotificationCategories
    {
        None = 0,
        ActivationItemReady = 1,
        ChestReadyForOpening = 2,
        SpawnerItemReady = 3,
        HotspotUnlockScheduleReached = 4,
        EnergyIsFull = 5,
        Debug = 6
    }
}