using System;
using GameLogic.Player.Items.Activation;
using GameLogic.Player.Items.Decay;
using Metaplay.Core;
using Metaplay.Core.Model;
using GameLogic.Merge;
using System.Runtime.Serialization;
using GameLogic.Player.Items.Spawning;
using GameLogic.Player.Items.Chest;
using GameLogic.Player.Items.Boosting;
using GameLogic.Player.Items.Bubble;
using GameLogic.Player.Items.Sink;
using GameLogic.Player.Items.TimeContainer;
using GameLogic.Player.Items.Charges;
using GameLogic.Player.Items.Merging;
using GameLogic.Player.Items.Attachments;
using GameLogic.MergeChains;
using GameLogic.Player.Board.Placement;
using Metaplay.Core.Math;
using GameLogic.Player.Items.Fishing;
using GameLogic.Player.Items.Persistent;
using Merge;
using System.Runtime.CompilerServices;
using GameLogic.Player.Items.Order;
using GameLogic.Config;
using GameLogic.Player.Items.GemMining;
using GameLogic.Config.Types;
using Metacore.MergeMansion.Common.Options;

namespace GameLogic.Player.Items
{
    [MetaSerializableDerived(2)]
    [MetaBlockedMembers(new int[] { 2 })]
    public class MergeItem : IMergeItem, IBoardItem
    {
        private static readonly MetaTime guaranteedFuture; // 0x0
        [IgnoreDataMember]
        public MergeItem.MergeItemExtra Extra => extra ??= new MergeItemExtra();

        [IgnoreDataMember]
        public DecayState DecayState => Extra.DecayState;

        [IgnoreDataMember]
        public ActivationState ActivationState => Extra.ActivationState;

        [IgnoreDataMember]
        public StorageState ActivationStorageState => Extra.ActivationStorageState;

        public void ResetStates(MetaTime timestamp)
        {
        }

        public void FlushStorages()
        {
        }

        public bool IsActivationStorageFull()
        {
            return Extra.ActivationStorageState.IsFull(DefinitionDef.GetDef(ClientGlobal.SharedGameConfig).ActivationFeatures.StorageMax);
        }

        public int GetCurrentAmountInActivationStorage()
        {
            return Extra.ActivationStorageState.GetCurrentAmount();
        }

        public bool TryToFillActivationStorage(MetaTime timestamp)
        {
            // STUB
            return false;
        }

        [MetaSerializable]
        public class MergeItemExtra
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public DecayState DecayState; // 0x10
            [MetaMember(2, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ActivationState ActivationState; // 0x18
            [MetaMember(4, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public StorageState ActivationStorageState; // 0x28
            [MetaMember(3, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public SpawnState SpawnState;
            [MetaMember(5, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public StorageState SpawnStorageState;
            [MetaMember(6, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ChestState ChestState;
            [MetaMember(7, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public BoosterState BoosterState;
            [MetaMember(8, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public BubbleState BubbleState;
            [MetaMember(9, (MetaMemberFlags)0)]
            public int SpecialActivationAmount;
            [MetaMember(10, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ISinkState SinkState;
            [MetaMember(12, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public TimeContainerState TimeContainerState;
            [MetaMember(13, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ChargesState ChargeState;
            [MetaMember(14, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public XpState ExperienceState;
            [MetaMember(15, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ItemAttachmentsState AttachmentsState;
            [MetaMember(16, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ItemLeaderboardState LeaderboardState;
            [MetaMember(17, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public ItemRewardsState RewardsState;
            public MergeItemExtra()
            {
            }

            [MetaMember(18, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public FishingRodState FishingRodState;
            [MetaMember(19, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public WeightState WeightState;
            [MetaMember(20, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public PersistentState PersistentState;
            [MetaMember(21, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public OrderParentState OrderState;
            [MetaMember(22, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public RockChunkState RockChunkState;
            [MetaMember(23, (MetaMemberFlags)0)]
            [MetaSerializerOmitNull]
            public GemState GemState;
        }

        [MetaMember(3, (MetaMemberFlags)0)]
        private ItemVisibility visibility;
        [MetaMember(4, (MetaMemberFlags)0)]
        private MergeItem.MergeItemExtra extra;
        [MetaMember(5, (MetaMemberFlags)0)]
        private MetaTime createdAt;
        [IgnoreDataMember]
        public SpawnState SpawnState { get; }

        [IgnoreDataMember]
        public StorageState SpawnStorageState { get; }

        [IgnoreDataMember]
        public IChestState ChestState { get; }

        [IgnoreDataMember]
        public BoosterState BoosterState { get; }

        [IgnoreDataMember]
        public BubbleState BubbleState { get; }

        [IgnoreDataMember]
        public int SpecialActivationAmount { get; }

        [IgnoreDataMember]
        public ISinkState SinkState { get; }

        [IgnoreDataMember]
        public ITimeContainerState TimeContainerState { get; }

        [IgnoreDataMember]
        public ChargesState ChargesState { get; }

        [IgnoreDataMember]
        public XpState ExperienceState { get; }

        [IgnoreDataMember]
        public ItemAttachmentsState AttachmentsState { get; }

        [IgnoreDataMember]
        public ItemAttachmentsState AttachmentsStateMaybe { get; }

        [IgnoreDataMember]
        public ItemLeaderboardState LeaderboardState { get; }

        [IgnoreDataMember]
        public ItemRewardsState RewardsState { get; }
        public int ItemId { get; }

        [IgnoreDataMember]
        public ItemVisibility Visibility { get; }

        [IgnoreDataMember]
        public MetaDuration? RemainingDuration { get; }

        [IgnoreDataMember]
        public MetaTime? NextSpawnStorageTimestamp { get; }

        [IgnoreDataMember]
        public bool IsLootable { get; }

        [IgnoreDataMember]
        public bool IsBoosted { get; }

        [IgnoreDataMember]
        public F32 TimeBoostMultiplier { get; }
        public bool IsInsideBubble { get; }

        [IgnoreDataMember]
        public bool IsVisible { get; }

        [IgnoreDataMember]
        public bool IsPartiallyVisible { get; }

        [IgnoreDataMember]
        public bool IsHiddenInABox { get; }

        [IgnoreDataMember]
        public bool ActivationPaused { get; set; }

        [IgnoreDataMember]
        public MetaDuration RemainingTimeContained { get; }

        [IgnoreDataMember]
        public bool IsFullyConsumed { get; }

        public MergeItem()
        {
        }

        private MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility)
        {
        }

        public MergeItem(IPlayer player, ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, bool insideBubble)
        {
        }

        public MergeItem(ItemDefinition resultingItem, MergeItem sourceItem, MetaTime timestamp)
        {
        }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState)
        {
        }

        [IgnoreDataMember]
        public FishingRodState FishingRodState { get; }

        [IgnoreDataMember]
        public FishingRodState FishingRodStateMaybe { get; }

        [IgnoreDataMember]
        public WeightState WeightState { get; }

        [IgnoreDataMember]
        public WeightState WeightStateMaybe { get; }
        public bool HasFishingRodState { get; }

        [IgnoreDataMember]
        public PersistentState PersistentState { get; }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, PersistentState persistentState)
        {
        }

        [IgnoreDataMember]
        public bool IsSpawnBoosted { get; }

        [IgnoreDataMember]
        public F32 TimeSpawnBoostMultiplier { get; }

        [IgnoreDataMember]
        public MetaTime CreatedAt { get; }

        private static string HotspotTagKey;
        public MergeItem(IPlayer player, ItemDefinition itemDefinition, MetaTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble)
        {
        }

        [IgnoreDataMember]
        public OrderParentState OrderState { get; }

        public MergeItem(SharedGameConfig config, ItemDefinition resultingItem, MergeItem sourceItem, MetaTime timestamp, IPlayer player)
        {
        }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, OrderParentState orderState, PersistentState persistentState)
        {
        }

        [IgnoreDataMember]
        public RockChunkState RockChunkState { get; }

        [IgnoreDataMember]
        public GemState GemState { get; }

        public MergeItem(IPlayer player, ItemDefinition itemDefinition, MetaTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble, bool checkNullExtra)
        {
        }

        public MergeItem(ItemDefinition itemDefinition, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, ChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, OrderParentState orderState, PersistentState persistentState, GemState gemState)
        {
        }

        public MergeItem(IMergeMansionGameConfig config, ItemDefinition resultingItem, MergeItem sourceItem, MetaTime timestamp, IPlayer player)
        {
        }

        private MergeItem(MetaRef<ItemDefinition> definitionRef, MetaTime timestamp, ItemVisibility itemVisibility)
        {
        }

        public MergeItem(IPlayer player, MetaRef<ItemDefinition> itemDefinitionRef, MetaTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble, bool checkNullExtra)
        {
        }

        public MergeItem(IMergeMansionGameConfig config, MetaRef<ItemDefinition> resultingItemRef, IMergeItem sourceItem, MetaTime timestamp, IPlayer player)
        {
        }

        public MergeItem(MetaRef<ItemDefinition> itemDefinitionRef, MetaTime timestamp, ItemVisibility itemVisibility, DecayState decayState, ActivationState activationState, StorageState activationStorage, SpawnState spawnState, StorageState spawnStorage, IChestState chestState, ISinkState sinkState, TimeContainerState timeContainerState, ChargesState chargesState, XpState xpState, OrderParentState orderState, PersistentState persistentState, GemState gemState)
        {
        }

        public MergeItem(IPlayer player, MetaRef<ItemDefinition> itemDefinitionRef, MetacoreTime timestamp, MergeBoardId boardId, ItemVisibility itemVisibility, bool insideBubble, bool checkNullExtra)
        {
        }

        public MergeItem(IMergeMansionGameConfig config, MetaRef<ItemDefinition> resultingItemRef, IMergeItem sourceItem, MetacoreTime timestamp, IPlayer player)
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaOnMemberDeserializationFailure("FixItemRef")]
        public ItemDef DefinitionDef { get; set; }

        [IgnoreDataMember]
        Option<MetaTime> GameLogic.Player.Items.IMergeItem.NextSpawnStorageTimestampOption { get; }
    }
}