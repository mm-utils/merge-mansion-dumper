using Metaplay.Core.Model;
using System;
using Metaplay.Core.Analytics;

namespace Metaplay.Core.Message
{
    [MetaSerializable]
    [FirebaseAnalyticsIgnore]
    public struct ClientLaunchStatistics
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public MetaDuration TotalStartDuration;
        [MetaMember(2, (MetaMemberFlags)0)]
        public int SystemMemoryMegabytes;
        [MetaMember(3, (MetaMemberFlags)0)]
        public string ProcessorType;
        [MetaMember(4, (MetaMemberFlags)0)]
        public string OperatingSystem;
        [MetaMember(10, (MetaMemberFlags)0)]
        public MetaDuration AppStartToSdkInitDuration;
        [MetaMember(11, (MetaMemberFlags)0)]
        public MetaDuration SdkInitDuration;
        [MetaMember(12, (MetaMemberFlags)0)]
        public MetaDuration SdkInitToConnectCalledDuration;
        [MetaMember(13, (MetaMemberFlags)0)]
        public MetaDuration CredentialInitDuration;
        [MetaMember(14, (MetaMemberFlags)0)]
        public MetaDuration CredentialResolveDuration;
        [MetaMember(20, (MetaMemberFlags)0)]
        public MetaDuration ConnectionTotalDuration;
        [MetaMember(21, (MetaMemberFlags)0)]
        public MetaDuration ConnectionHandshakeDnsDuration;
        [MetaMember(22, (MetaMemberFlags)0)]
        public MetaDuration ConnectionHandshakeTcpDuration;
        [MetaMember(23, (MetaMemberFlags)0)]
        public MetaDuration ConnectionHandshakeTlsDuration;
        [MetaMember(30, (MetaMemberFlags)0)]
        public MetaDuration LoginDuration;
        [MetaMember(31, (MetaMemberFlags)0)]
        public MetaDuration SessionNegotiationDuration;
        [MetaMember(32, (MetaMemberFlags)0)]
        public MetaDuration SessionNegotiationDownloadDuration;
        [MetaMember(34, (MetaMemberFlags)0)]
        public MetaDuration SessionResourceParseDuration;
        [MetaMember(35, (MetaMemberFlags)0)]
        public MetaDuration SessionStartDuration;
    }
}