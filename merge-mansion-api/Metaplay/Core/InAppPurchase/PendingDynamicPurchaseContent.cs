using Metaplay.Core.Model;
using System;
using Metaplay.Core.Player;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    public class PendingDynamicPurchaseContent
    {
        [IgnoreDefValidation]
        [MetaMember(1, (MetaMemberFlags)0)]
        public DynamicPurchaseContent Content;
        [MetaMember(3, (MetaMemberFlags)0)]
        public string DeviceId;
        [MetaMember(2, (MetaMemberFlags)0)]
        [NoChecksum]
        [Transient]
        public PendingDynamicPurchaseContentStatus Status;
        [MetaMember(4, (MetaMemberFlags)0)]
        public string GameProductAnalyticsId;
        [MetaMember(5, (MetaMemberFlags)0)]
        public PurchaseAnalyticsContext GameAnalyticsContext;
        public PendingDynamicPurchaseContent()
        {
        }

        public PendingDynamicPurchaseContent(DynamicPurchaseContent content, string deviceId, string gameProductAnalyticsId, PurchaseAnalyticsContext gameAnalyticsContext, PendingDynamicPurchaseContentStatus status)
        {
        }
    }
}