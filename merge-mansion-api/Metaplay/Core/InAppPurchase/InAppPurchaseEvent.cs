using Metaplay.Core.Model;
using Metaplay.Core.Serialization;
using System;
using Metaplay.Core.Math;
using Metaplay.Core.Player;

namespace Metaplay.Core.InAppPurchase
{
    [MetaSerializable]
    [MetaReservedMembers(1, 12)]
    [MetaReservedMembers(13, 17)]
    [MetaReservedMembers(18, 100)]
    [MetaDeserializationConvertFromIntegrationImplementation]
    public abstract class InAppPurchaseEvent : IMetaIntegrationConstructible<InAppPurchaseEvent>, IMetaIntegration<InAppPurchaseEvent>, IMetaIntegration, IMetaIntegrationConstructible, IRequireSingleConcreteType
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public InAppPurchasePlatform Platform { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public string TransactionId { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public InAppProductId ProductId { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public string PlatformProductId { get; set; }

        [PrettyPrint((PrettyPrintFlag)4)]
        [MetaMember(5, (MetaMemberFlags)0)]
        public string Receipt { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string Signature { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public InAppPurchaseStatus Status { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        public bool IsDuplicateTransaction { get; set; }

        [MetaMember(18, (MetaMemberFlags)0)]
        [ServerOnly]
        public int NumValidationsStarted { get; set; }

        [MetaMember(19, (MetaMemberFlags)0)]
        [ServerOnly]
        public int NumValidationTransientErrors { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        public MetaTime PurchaseTime { get; set; }

        [MetaMember(10, (MetaMemberFlags)0)]
        public F64 ReferencePrice { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public MetaTime ClaimTime { get; set; }

        [IgnoreDefValidation]
        [MetaMember(13, (MetaMemberFlags)0)]
        public DynamicPurchaseContent DynamicContent { get; set; }

        [MetaMember(22, (MetaMemberFlags)0)]
        public bool HasMissingContent { get; set; }

        [MetaMember(14, (MetaMemberFlags)0)]
        public ResolvedPurchaseContentBase ResolvedContent { get; set; }

        [IgnoreDefValidation]
        [MetaMember(15, (MetaMemberFlags)0)]
        public ResolvedPurchaseMetaRewards ResolvedDynamicContent { get; set; }

        [MetaMember(20, (MetaMemberFlags)0)]
        public string GameProductAnalyticsId { get; set; }

        [MetaMember(21, (MetaMemberFlags)0)]
        public MetaSerialized<PurchaseAnalyticsContext> GamePurchaseAnalyticsContext { get; set; }

        [MetaMember(23, (MetaMemberFlags)0)]
        public SubscriptionQueryResult SubscriptionQueryResult { get; set; }

        [MetaMember(24, (MetaMemberFlags)0)]
        public string OriginalTransactionIdIfDifferentFromTransactionId { get; set; }
        public string OriginalTransactionId { get; }

        [MetaMember(25, (MetaMemberFlags)0)]
        public InAppPurchasePaymentType? PaymentType { get; set; }

        protected InAppPurchaseEvent()
        {
        }

        public string PlatformSpecificTransactionId { get; }

        [MetaMember(16, (MetaMemberFlags)0)]
        public string AlternativePurchaseId { get; set; }
        public string PlatformSpecificOriginalTransactionId { get; }

        [MetaMember(26, (MetaMemberFlags)0)]
        public ServerDrivenInAppPurchaseEventState ServerDriven { get; set; }

        [MetaMember(27, (MetaMemberFlags)0)]
        public InAppPurchaseEventPlatformState PlatformState { get; set; }

        [MetaMember(28, (MetaMemberFlags)0)]
        public InAppPurchaseEventRefundState Refund { get; set; }

        [MetaMember(29, (MetaMemberFlags)0)]
        [ServerOnly]
        public InAppPurchasePendingRefundHandling PendingRefundToHandle { get; set; }
    }
}