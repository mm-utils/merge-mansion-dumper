using System.Collections.Generic;
using Metaplay.Core.Client;
using Metaplay.Core.Localization;
using Metaplay.Core.Model;
using Metaplay.Core.MultiplayerEntity.Messages;
using Metaplay.Core.Player;
using Metaplay.Core.Serialization;
using Metaplay.Core.Session;
using System;
using Metaplay.Core.Math;
using Metacore;

namespace Metaplay.Core.Message
{
    public static class SessionProtocol
    {
        [MetaSerializable]
        public class SessionResourceCorrection
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public Dictionary<ClientSlot, ConfigArchiveUpdateInfo> ConfigUpdates; // 0x10
            [MetaMember(2, (MetaMemberFlags)0)]
            public Dictionary<ClientSlot, ConfigPatchesUpdateInfo> PatchUpdates; // 0x18
            [MetaMember(3, (MetaMemberFlags)0)]
            public LanguageUpdateInfo? LanguageUpdate; // 0x20
            public SessionResourceCorrection()
            {
                ConfigUpdates = new Dictionary<ClientSlot, ConfigArchiveUpdateInfo>();
                PatchUpdates = new Dictionary<ClientSlot, ConfigPatchesUpdateInfo>();
                LanguageUpdate = null;
            }

            public bool HasAnyCorrection()
            {
                if (ConfigUpdates.Count >= 1)
                    return true;
                if (PatchUpdates.Count >= 1)
                    return true;
                return LanguageUpdate.HasValue;
            }

            public static SessionResourceCorrection Combine(SessionResourceCorrection a, SessionResourceCorrection b)
            {
                var correction = new SessionResourceCorrection();
                foreach (var update in a.ConfigUpdates)
                    correction.ConfigUpdates.Add(update.Key, update.Value);
                foreach (var update in b.ConfigUpdates)
                    correction.ConfigUpdates.Add(update.Key, update.Value);
                foreach (var update in a.PatchUpdates)
                    correction.PatchUpdates.Add(update.Key, update.Value);
                foreach (var update in b.PatchUpdates)
                    correction.PatchUpdates.Add(update.Key, update.Value);
                correction.LanguageUpdate = a.LanguageUpdate ?? b.LanguageUpdate;
                return correction;
            }

            [MetaSerializable]
            public struct ConfigArchiveUpdateInfo
            {
                [MetaMember(1, (MetaMemberFlags)0)]
                public ContentHash SharedGameConfigVersion; // 0x0
                [MetaMember(2, (MetaMemberFlags)0)]
                public string UrlSuffix; // 0x10
                public ConfigArchiveUpdateInfo(ContentHash sharedGameConfigVersion, string urlSuffix)
                {
                    SharedGameConfigVersion = sharedGameConfigVersion;
                    UrlSuffix = urlSuffix;
                }
            }

            [MetaSerializable]
            public struct ConfigPatchesUpdateInfo
            {
                [MetaMember(1, (MetaMemberFlags)0)]
                public ContentHash PatchesVersion; // 0x0
                public ConfigPatchesUpdateInfo(ContentHash patchesVersion)
                {
                    PatchesVersion = patchesVersion;
                }
            }

            [MetaSerializable((MetaSerializableFlags)1)]
            [MetaImplicitMembersRange(1, 100)]
            public struct LanguageUpdateInfo
            {
                public LanguageId ActiveLanguage; // 0x0
                public ContentHash LocalizationVersion; // 0x8
                public LanguageUpdateInfo(LanguageId activeLanguage, ContentHash localizationVersion)
                {
                    ActiveLanguage = activeLanguage;
                    LocalizationVersion = localizationVersion;
                }
            }
        }

        [MetaSerializable]
        public class InitialPlayerState
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public MetaSerialized<IPlayerModelBase> PlayerModel { get; set; } // 0x10

            [MetaMember(2, (MetaMemberFlags)0)]
            public int CurrentOperation { get; set; } // 0x20

            private InitialPlayerState()
            {
            }

            public InitialPlayerState(MetaSerialized<IPlayerModelBase> playerModel, int currentOperation)
            {
                PlayerModel = playerModel;
                CurrentOperation = currentOperation;
            }

            [MetaMember(3, (MetaMemberFlags)0)]
            public PlayerDebugConfig DebugConfig { get; set; }

            public InitialPlayerState(MetaSerialized<IPlayerModelBase> playerModel, int currentOperation, EntityDebugConfig debugConfig)
            {
            }

            [MetaMember(4, (MetaMemberFlags)0)]
            public ContentHash SharedGameConfigVersion { get; set; }

            [MetaMember(5, (MetaMemberFlags)0)]
            public ContentHash SharedConfigPatchesVersion { get; set; }

            [MetaMember(6, (MetaMemberFlags)0)]
            public EntityActiveExperiment[] ActiveExperiments { get; set; }

            public InitialPlayerState(MetaSerialized<IPlayerModelBase> playerModel, int currentOperation, EntityDebugConfig debugConfig, ContentHash sharedGameConfigVersion, ContentHash sharedConfigPatchesVersion, EntityActiveExperiment[] activeExperiments)
            {
            }
        }

        [MetaSerializable]
        public struct SessionResourceProposal
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public HashSet<ContentHash> ConfigVersions { get; set; } // 0x0

            [MetaMember(2, (MetaMemberFlags)0)]
            public HashSet<ContentHash> PatchVersions { get; set; } // 0x8

            [MetaMember(10, (MetaMemberFlags)0)]
            public LanguageId ClientActiveLanguage { get; set; } // 0x10

            [MetaMember(11, (MetaMemberFlags)0)]
            public ContentHash ClientLocalizationVersion { get; set; } // 0x18

            public SessionResourceProposal(HashSet<ContentHash> configVersions, HashSet<ContentHash> patchVersions, LanguageId clientActiveLanguage, ContentHash clientLocalizationVersion)
            {
                ConfigVersions = configVersions;
                PatchVersions = patchVersions;
                ClientActiveLanguage = clientActiveLanguage;
                ClientLocalizationVersion = clientLocalizationVersion;
            }
        }

        public struct ServerOptions
        {
            [MetaMember(1, 0)]
            public int PushUploadPercentageSessionStartFailedIncidentReport; // 0x0
            [MetaMember(2, 0)]
            public bool EnableWireCompression; // 0x4
            [MetaMember(3, 0)]
            public MetaDuration DeletionRequestSafetyDelay; // 0x8
            [MetaMember(4, 0)]
            public string GameServerGooglePlaySignInOAuthClientId; // 0x10
            [MetaMember(5, 0)]
            public string ImmutableXLinkApiUrl; // 0x18
            [MetaMember(6, 0)]
            public string GameEnvironment; // 0x20
            public ServerOptions(int pushUploadPercentageSessionStartFailedIncidentReport, bool enableWireCompression, MetaDuration deletionRequestSafetyDelay, string gameServerGooglePlaySignInOAuthClientId, string immutableXLinkApiUrl, string gameEnvironment)
            {
                PushUploadPercentageSessionStartFailedIncidentReport = pushUploadPercentageSessionStartFailedIncidentReport;
                EnableWireCompression = enableWireCompression;
                DeletionRequestSafetyDelay = deletionRequestSafetyDelay;
                GameServerGooglePlaySignInOAuthClientId = gameServerGooglePlaySignInOAuthClientId;
                ImmutableXLinkApiUrl = immutableXLinkApiUrl;
                GameEnvironment = gameEnvironment;
            }
        }

        [MetaMessage(16, (MessageDirection)1, true)]
        [MessageRoutingRuleProtocol]
        public class SessionStartRequest : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public int QueryId { get; set; } // 0x10

            [MetaMember(2, (MetaMemberFlags)0)]
            public string DeviceGuid { get; set; } // 0x18

            [MetaMember(3, (MetaMemberFlags)0)]
            public SessionProtocol.ClientDeviceInfo DeviceInfo { get; set; }

            [MetaMember(4, (MetaMemberFlags)0)]
            public PlayerTimeZoneInfo TimeZoneInfo { get; set; } // 0x28

            [MetaMember(5, (MetaMemberFlags)0)]
            public SessionProtocol.SessionResourceProposal ResourceProposal { get; set; } // 0x30

            [MetaMember(7, (MetaMemberFlags)0)]
            public ISessionStartRequestGamePayload GamePayload { get; set; } // 0x60

            [MetaMember(8, (MetaMemberFlags)0)]
            public CompressionAlgorithmSet SupportedArchiveCompressions { get; set; } // 0x68

            [MetaMember(9, (MetaMemberFlags)0)]
            public ClientAppPauseStatus ClientAppPauseStatus { get; set; } // 0x6C

            private SessionStartRequest()
            {
            }

            public SessionStartRequest(int queryId, string deviceGuid, SessionProtocol.ClientDeviceInfo deviceInfo, PlayerTimeZoneInfo timeZoneInfo, SessionResourceProposal resourceProposal, ISessionStartRequestGamePayload gamePayload, CompressionAlgorithmSet supportedArchiveCompressions, ClientAppPauseStatus clientAppPauseStatus)
            {
                QueryId = queryId;
                DeviceGuid = deviceGuid;
                DeviceInfo = deviceInfo;
                TimeZoneInfo = timeZoneInfo;
                ResourceProposal = resourceProposal;
                GamePayload = gamePayload;
                SupportedArchiveCompressions = supportedArchiveCompressions;
                ClientAppPauseStatus = clientAppPauseStatus;
                ResourceProposal = new SessionResourceProposal
                {
                    ConfigVersions = new HashSet<ContentHash>(),
                    PatchVersions = new HashSet<ContentHash>(),
                    ClientActiveLanguage = LanguageId.FromString("en"),
                    ClientLocalizationVersion = new ContentHash(new MetaUInt128(0xD4B4D04FCA615E18, 0xB5774112D9F05D30))
                };
            }

            [MetaMember(10, (MetaMemberFlags)0)]
            public PlayerLocation? OverrideLocation { get; set; }

            public SessionStartRequest(int queryId, string deviceGuid, SessionProtocol.ClientDeviceInfo deviceInfo, PlayerTimeZoneInfo timeZoneInfo, SessionProtocol.SessionResourceProposal resourceProposal, ISessionStartRequestGamePayload gamePayload, CompressionAlgorithmSet supportedArchiveCompressions, ClientAppPauseStatus clientAppPauseStatus, PlayerLocation? overrideLocation)
            {
            }

            [MetaMember(100, (MetaMemberFlags)0)]
            public string IpAddress { get; set; }

            [MetaMember(101, (MetaMemberFlags)0)]
            public int StoredIpAddress { get; set; }

            public SessionStartRequest(int queryId, string deviceGuid, SessionProtocol.ClientDeviceInfo deviceInfo, PlayerTimeZoneInfo timeZoneInfo, SessionProtocol.SessionResourceProposal resourceProposal, ISessionStartRequestGamePayload gamePayload, CompressionAlgorithmSet supportedArchiveCompressions, ClientAppPauseStatus clientAppPauseStatus, PlayerLocation? overrideLocation, string ipAddress, RestoreCountryCode.StoredIpAddressKind storedIpAddressKind)
            {
            }
        }

        [MetaMessage(17, (MessageDirection)2, true)]
        public class SessionStartSuccess : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public int QueryId { get; set; } // 0x10

            [MetaMember(2, (MetaMemberFlags)0)]
            public int LogicVersion { get; set; } // 0x14

            [MetaMember(3, (MetaMemberFlags)0)]
            public SessionToken SessionToken { get; set; } // 0x18

            [MetaMember(4, (MetaMemberFlags)0)]
            public ScheduledMaintenanceModeForClient ScheduledMaintenanceMode { get; set; } // 0x20

            [MetaMember(5, (MetaMemberFlags)0)]
            public EntityId PlayerId { get; set; } // 0x28

            [MetaMember(6, (MetaMemberFlags)0)]
            public SessionProtocol.InitialPlayerState PlayerState { get; set; } // 0x30

            [MetaMember(8, (MetaMemberFlags)0)]
            public Dictionary<LanguageId, ContentHash> LocalizationVersions { get; set; } // 0x38

            [MetaMember(10, (MetaMemberFlags)0)]
            public bool DeveloperMaintenanceBypass { get; set; } // 0x48

            [MetaMember(11, (MetaMemberFlags)0)]
            public List<EntityInitialState> EntityStates { get; set; } // 0x50

            [MetaMember(12, (MetaMemberFlags)0)]
            public ISessionStartSuccessGamePayload GamePayload { get; set; } // 0x58

            [MetaMember(14, (MetaMemberFlags)0)]
            public string CorrectedDeviceGuid { get; set; } // 0x60

            private SessionStartSuccess()
            {
            }

            public SessionStartSuccess(int queryId, int logicVersion, SessionToken sessionToken, ScheduledMaintenanceModeForClient scheduledMaintenanceMode, EntityId playerId, InitialPlayerState playerState, Dictionary<LanguageId, ContentHash> localizationVersions, List<EntityActiveExperiment> activeExperiments, bool developerMaintenanceBypass, List<EntityInitialState> entityStates, ISessionStartSuccessGamePayload gamePayload, string correctDeviceGuid)
            {
                QueryId = queryId;
                LogicVersion = logicVersion;
                SessionToken = sessionToken;
                ScheduledMaintenanceMode = scheduledMaintenanceMode;
                PlayerId = playerId;
                PlayerState = playerState;
                LocalizationVersions = localizationVersions;
                DeveloperMaintenanceBypass = developerMaintenanceBypass;
                EntityStates = entityStates;
                GamePayload = gamePayload;
                CorrectedDeviceGuid = correctDeviceGuid;
            }

            [Sensitive]
            [MetaMember(15, (MetaMemberFlags)0)]
            public byte[] ResumptionToken { get; set; }

            public SessionStartSuccess(int queryId, int logicVersion, SessionToken sessionToken, ScheduledMaintenanceModeForClient scheduledMaintenanceMode, EntityId playerId, SessionProtocol.InitialPlayerState playerState, Dictionary<LanguageId, ContentHash> localizationVersions, List<EntityActiveExperiment> activeExperiments, bool developerMaintenanceBypass, List<EntityInitialState> entityStates, ISessionStartSuccessGamePayload gamePayload, string correctedDeviceGuid, byte[] resumptionToken)
            {
            }

            public SessionStartSuccess(int queryId, int logicVersion, SessionToken sessionToken, ScheduledMaintenanceModeForClient scheduledMaintenanceMode, EntityId playerId, SessionProtocol.InitialPlayerState playerState, Dictionary<LanguageId, ContentHash> localizationVersions, bool developerMaintenanceBypass, List<EntityInitialState> entityStates, ISessionStartSuccessGamePayload gamePayload, string correctedDeviceGuid, byte[] resumptionToken)
            {
            }
        }

        [MetaMessage(18, (MessageDirection)2, true)]
        public class SessionStartFailure : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public int QueryId { get; set; } // 0x10

            [MetaMember(2, (MetaMemberFlags)0)]
            public SessionProtocol.SessionStartFailure.ReasonCode Reason { get; set; } // 0x14

            [MetaMember(4, (MetaMemberFlags)0)]
            public string DebugOnlyErrorMessage { get; set; } // 0x18

            private SessionStartFailure()
            {
            }

            public SessionStartFailure(int queryId, ReasonCode reason, string debugOnlyErrorMessage)
            {
                QueryId = queryId;
                Reason = reason;
                DebugOnlyErrorMessage = debugOnlyErrorMessage;
            }

            [MetaSerializable]
            public enum ReasonCode
            {
                InternalError = 0,
                Banned = 3,
                PlayerDeserializationFailure = 4,
                WrongAuthenticationPlatform = 5,
                LogicVersionDowngradeNotAllowed = 5,
                Deleted = 6
            }

            public SessionStartFailure(int queryId, SessionProtocol.SessionStartFailure.ReasonCode reason, string debugOnlyErrorMessage, MetaTime? banExpirationTime, string banReason)
            {
            }

            [MetaMember(5, (MetaMemberFlags)0)]
            public SessionProtocol.SessionStartFailureData ReasonSpecificData { get; set; }
        }

        [MetaMessage(19, MessageDirection.ClientToServer, true)]
        [MessageRoutingRuleProtocol]
        public class SessionResumeRequest : MetaMessage
        {
            [MetaMember(1, 0)]
            public SessionResumptionInfo SessionToResume { get; set; } // 0x10

            private SessionResumeRequest()
            {
            }

            public SessionResumeRequest(SessionResumptionInfo sessionToResume)
            {
                SessionToResume = sessionToResume;
            }
        }

        [MetaMessage(20, (MessageDirection)2, true)]
        public class SessionResumeSuccess : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public SessionAcknowledgement ServerSessionAcknowledgement { get; set; } // 0x10

            [MetaMember(2, (MetaMemberFlags)0)]
            public SessionToken SessionToken { get; set; } // 0x18

            [MetaMember(3, (MetaMemberFlags)0)]
            public ScheduledMaintenanceModeForClient ScheduledMaintenanceMode { get; set; } // 0x20

            private SessionResumeSuccess()
            {
            }

            public SessionResumeSuccess(SessionAcknowledgement serverSessionAcknowledgement, SessionToken sessionToken, ScheduledMaintenanceModeForClient scheduledMaintenanceMode)
            {
                ServerSessionAcknowledgement = serverSessionAcknowledgement;
                SessionToken = sessionToken;
                ScheduledMaintenanceMode = scheduledMaintenanceMode;
            }
        }

        [MetaMessage(21, (MessageDirection)2, true)]
        public class SessionResumeFailure : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public bool GenerateIncidentReport;
            public SessionResumeFailure(bool generateIncidentReport)
            {
            }
        }

        [MetaMessage(43, (MessageDirection)1, true)]
        [MessageRoutingRuleProtocol]
        public class SessionStartAbortReasonTrailer : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public string IncidentId { get; set; }

            [MetaMember(2, (MetaMemberFlags)0)]
            public byte[] Incident { get; set; }

            private SessionStartAbortReasonTrailer()
            {
            }

            public SessionStartAbortReasonTrailer(string incidentId, byte[] incident)
            {
                IncidentId = incidentId;
                Incident = incident;
            }
        }

        [MetaSerializable]
        public interface ISessionStartRequestGamePayload
        {
        }

        [MetaMessage(42, (MessageDirection)1, true)]
        [MessageRoutingRuleProtocol]
        public class SessionStartAbort : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public bool HasReasonTrailer { get; set; }

            private SessionStartAbort()
            {
            }

            public SessionStartAbort(bool hasReasonTrailer)
            {
            }
        }

        [MetaMessage(44, (MessageDirection)2, true)]
        public class SessionStartResourceCorrection : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public int QueryId { get; set; }

            [MetaMember(2, (MetaMemberFlags)0)]
            public SessionProtocol.SessionResourceCorrection ResourceCorrection { get; set; }

            private SessionStartResourceCorrection()
            {
            }

            public SessionStartResourceCorrection(int queryId, SessionProtocol.SessionResourceCorrection resourceCorrection)
            {
            }
        }

        [MetaSerializable]
        public struct ClientDeviceInfo
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public ClientPlatform ClientPlatform { get; set; }

            [MetaMember(2, (MetaMemberFlags)0)]
            public string DeviceModel { get; set; }

            [MetaMember(3, (MetaMemberFlags)0)]
            public string OperatingSystem { get; set; }
        }

        [MetaSerializable]
        public abstract class SessionStartFailureData
        {
        }

        [MetaSerializableDerived(1)]
        public class SessionStartFailedBannedInfo : SessionProtocol.SessionStartFailureData
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public PlayerBanInfo BanInfo { get; set; }
        }

        [MetaMessage(113, (MessageDirection)2, true)]
        public class SessionStartSuccessFragment : MetaMessage
        {
            [MetaMember(1, (MetaMemberFlags)0)]
            public byte[] Fragment;
        }
    }
}