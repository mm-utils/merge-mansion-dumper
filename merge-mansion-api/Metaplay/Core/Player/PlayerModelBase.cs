using Metaplay.Core.Model;
using System;
using System.Runtime.Serialization;
using Metaplay.Core.Config;
using Metaplay.Core.Analytics;
using Metaplay.Core.Session;
using Metaplay.Core.Localization;
using System.Collections.Generic;
using Metaplay.Core.InAppPurchase;
using Metaplay.Core.Math;
using Metaplay.Core.InGameMail;
using Metaplay.Core.Web3;
using Metaplay.Core.Client;
using Metaplay.Core.Offers;
using Metaplay.Core.LiveOpsEvent;

namespace Metaplay.Core.Player
{
    [MetaBlockedMembers(new int[] { 9, 15, 20, 21, 26, 27, 36, 44 })]
    [MetaReservedMembers(1, 6)]
    [MetaReservedMembers(7, 10)]
    [MetaReservedMembers(12, 99)]
    [MetaReservedMembers(10000, 20000)]
    public abstract class PlayerModelBase<TPlayerModel, TPlayerStatistics, TPlayerMetaOfferGroups, TPlayerGuildState> : IPlayerModel<TPlayerModel>, IPlayerModelBase, IModel<IPlayerModelBase>, IModel, ISchemaMigratable, IMetaIntegration<ISchemaMigratable>, IMetaIntegration, IMetaIntegrationConstructible<IPlayerModelBase>, IMetaIntegration<IPlayerModelBase>, IMetaIntegrationConstructible, IRequireSingleConcreteType
    {
        private static int CurrentBaseFixupVersion;
        [MetaMember(49, (MetaMemberFlags)0)]
        private int _baseFixupVersion;
        public int LogicVersion { get; set; }

        [IgnoreDataMember]
        public ISharedGameConfig GameConfig { get; set; }

        [IgnoreDataMember]
        public LogChannel Log { get; set; }

        [IgnoreDataMember]
        public IPlayerModelServerListenerCore ServerListenerCore { get; set; }

        [IgnoreDataMember]
        public IPlayerModelClientListenerCore ClientListenerCore { get; set; }

        [IgnoreDataMember]
        public AnalyticsEventHandler<IPlayerModelBase, PlayerEventBase> AnalyticsEventHandler { get; set; }

        int Metaplay.Core.Player.IPlayerModelBase.TicksPerSecond { get; }
        public MetaTime CurrentTime { get; }
        public MetaTime CurrentTimeWithoutDebugTimeOffset { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        [Transient]
        [ExcludeFromGdprExport]
        public MetaTime TimeAtFirstTick { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [Transient]
        [ExcludeFromGdprExport]
        public long CurrentTick { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [Transient]
        [NoChecksum]
        [ExcludeFromGdprExport]
        public bool IsOnline { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [Transient]
        [NoChecksum]
        [ExcludeFromGdprExport]
        public string SessionDeviceGuid { get; set; }

        [MetaMember(40, (MetaMemberFlags)0)]
        [Transient]
        [NoChecksum]
        [ExcludeFromGdprExport]
        public SessionToken SessionToken { get; set; }
        public bool IsBanned { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public PlayerTimeZoneInfo TimeZoneInfo { get; set; }

        [MetaMember(34, (MetaMemberFlags)0)]
        public PlayerLocation? LastKnownLocation { get; set; }
        public PlayerStatisticsBase Stats { get; set; }

        [MetaMember(13, (MetaMemberFlags)0)]
        public LanguageId Language { get; set; }

        [MetaMember(37, (MetaMemberFlags)0)]
        public LanguageSelectionSource LanguageSelectionSource { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public List<string> FirebaseMessagingTokensLegacy { get; set; }

        [MetaMember(33, (MetaMemberFlags)0)]
        [ExcludeFromGdprExport]
        public PlayerPushNotifications PushNotifications { get; set; }

        [MetaMember(50, (MetaMemberFlags)0)]
        [ServerOnly]
        public int NumDuplicateInAppPurchases { get; set; }

        [MetaMember(51, (MetaMemberFlags)0)]
        [ServerOnly]
        public List<InAppPurchaseEvent> DuplicateInAppPurchaseHistory { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        [ServerOnly]
        public int NumFailedInAppPurchases { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        [ServerOnly]
        public List<InAppPurchaseEvent> FailedInAppPurchaseHistory { get; set; }

        [MetaMember(17, (MetaMemberFlags)0)]
        [NoChecksum]
        public Dictionary<string, InAppPurchaseEvent> PendingInAppPurchases { get; set; }

        [MetaMember(35, (MetaMemberFlags)0)]
        public Dictionary<InAppProductId, PendingDynamicPurchaseContent> PendingDynamicPurchaseContents { get; set; }

        [MetaMember(41, (MetaMemberFlags)0)]
        public Dictionary<InAppProductId, PendingNonDynamicPurchaseContext> PendingNonDynamicPurchaseContexts { get; set; }

        [MetaMember(46, (MetaMemberFlags)0)]
        public PlayerSubscriptionsModel IAPSubscriptions { get; set; }
        public F64 TotalIapSpend { get; set; }

        [MetaMember(45, (MetaMemberFlags)0)]
        public List<PlayerMailItem> MailInbox { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        [ServerOnly]
        [ExcludeFromGdprExport]
        public HashSet<int> ReceivedBroadcastIds { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        [ServerOnly]
        public Dictionary<string, PlayerDeviceEntry> DeviceHistory { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        [ServerOnly]
        public List<PlayerLoginEvent> LoginHistory { get; set; }

        [MetaMember(25, (MetaMemberFlags)0)]
        [NoChecksum]
        public Dictionary<AuthenticationKey, LegacyPlayerAuthEntry> LegacyAttachedAuthMethods { get; set; }

        [MetaMember(54, (MetaMemberFlags)0)]
        [NoChecksum]
        public Dictionary<AuthenticationKey, PlayerAuthEntryBase> AttachedAuthMethods { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        [NoChecksum]
        public PlayerDeletionStatus DeletionStatus { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        [NoChecksum]
        public MetaTime ScheduledForDeletionAt { get; set; }

        [PrettyPrint((PrettyPrintFlag)16)]
        [MetaMember(30, (MetaMemberFlags)0)]
        [ServerOnly]
        [IgnoreDefValidation]
        public PlayerEventLog EventLog { get; set; }
        public IPlayerGuildState GuildState { get; set; }

        [MetaMember(32, (MetaMemberFlags)0)]
        [ServerOnly]
        public PlayerPendingSynchronizedServerActions PendingSynchronizedServerActions { get; set; }

        [MetaMember(38, (MetaMemberFlags)0)]
        [ServerOnly]
        public int SearchVersion { get; set; }

        [MetaMember(39, (MetaMemberFlags)0)]
        [ServerOnly]
        public PlayerExperimentsState Experiments { get; set; }
        public IPlayerMetaOfferGroups MetaOfferGroups { get; set; }

        [MetaMember(43, (MetaMemberFlags)0)]
        [Transient]
        public bool IsDeveloper { get; set; }

        [MetaMember(47, (MetaMemberFlags)0)]
        [Transient]
        [ServerOnly]
        public bool IsClientConnected { get; set; }

        [MetaMember(48, (MetaMemberFlags)0)]
        [Transient]
        [ServerOnly]
        public ClientAppPauseStatus ClientAppPauseStatus { get; set; }

        [MetaMember(52, (MetaMemberFlags)0)]
        public PlayerNftSubModel Nft { get; set; }

        [MetaMember(53, (MetaMemberFlags)0)]
        public Dictionary<ClientSlot, PlayerSubClientStateBase> PlayerSubClientStates { get; set; }

        IPlayerMetaOfferGroups Metaplay.Core.Player.IPlayerModelBase.MetaOfferGroups { get; }

        [IgnoreDataMember]
        protected virtual bool ShouldRefreshMetaOffersAtSessionStart { get; }

        PlayerStatisticsBase Metaplay.Core.Player.IPlayerModelBase.Stats { get; }

        IPlayerGuildState Metaplay.Core.Player.IPlayerModelBase.GuildState { get; }
        public abstract EntityId PlayerId { get; set; }
        public abstract string PlayerName { get; set; }
        public abstract int PlayerLevel { get; set; }
        public virtual MetaDuration DebugTimeOffset { get; }

        protected PlayerModelBase()
        {
        }

        [MetaMember(55, (MetaMemberFlags)0)]
        public PlayerLiveOpsEventsModel LiveOpsEvents { get; set; }

        [MetaMember(56, (MetaMemberFlags)0)]
        [ServerOnly]
        public PlayerSessionDebugMode SessionDebugModeOverride { get; set; }

        [IgnoreDataMember]
        public IPlayerModelClientListenerCoreInternal ClientListenerCoreInternal { get; set; }

        [MetaMember(59, (MetaMemberFlags)0)]
        [Transient]
        [NoChecksum]
        [ExcludeFromGdprExport]
        public AuthenticationKey SessionAuthenticationKey { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [NoChecksum]
        [Obsolete]
        internal bool LegacyIsBanned { get; set; }

        [MetaMember(57, (MetaMemberFlags)0)]
        [NoChecksum]
        [ServerOnly]
        public PlayerBanInfo BanInfo { get; set; }
        public bool IsPermaBanned { get; }

        [MetaMember(58, (MetaMemberFlags)0)]
        public Dictionary<AuthenticationPlatform, IPlatformSpecificData> PlatformSpecificData { get; set; }

        [MetaMember(16, (MetaMemberFlags)0)]
        [ServerOnly]
        public List<InAppPurchaseEvent> FullInAppPurchaseHistory { get; set; }

        [MetaMember(60, (MetaMemberFlags)0)]
        [Transient]
        public InAppPurchaseHistory InAppPurchaseHistorySummary { get; set; }
    }
}