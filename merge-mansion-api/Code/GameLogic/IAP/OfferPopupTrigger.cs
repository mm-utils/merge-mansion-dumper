using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using System;
using System.Collections.Generic;
using GameLogic.Player.Requirements;
using GameLogic.Config;
using Metaplay.Core;

namespace Code.GameLogic.IAP
{
    [MetaSerializable]
    public class OfferPopupTrigger : IGameConfigData<OfferPopupTriggerId>, IGameConfigData, IHasGameConfigKey<OfferPopupTriggerId>, IValidatable
    {
        public static string ShowMethodBadgeClicked { get; }
        public static string ShowMethodManualActivation { get; }
        public static string ShowMethodShopPopup { get; }
        public static string ShowMethodAppLoading { get; }
        public static string ShowMethodLobbyReturn { get; }
        public static string ShowMethodWebShop { get; }
        public static string ShowMethodMergeBoardEnter { get; }
        public static string ShowMethodPopupOpen { get; }
        public static string ShowMethodPopupClose { get; }
        public static string ShowMethodPendingTimeExtensionOffer { get; }
        public static string ShowMethodExtendGameEvent { get; }
        public static string ShowMethodPromptOpenShopNotYetOpened { get; }
        public static string ShowMethodShopHasARefreshedSection { get; }
        public static string ShowMethodPromptForFreeOffer { get; }
        public static string ShowMethodEventPassPurchaseClicked { get; }
        public static string ShowMethodMysteryMachineOutOfCurrencyConfirmation { get; }
        public static string ShowMethodProgressionPackLastChance { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        public OfferPopupTriggerId ConfigKey { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private int MaxTriggersPerSession { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        private int MaxTriggersTotal { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        private List<PlayerRequirement> TriggerRequirements { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        private Dictionary<OfferPopupTriggerPlacementType, List<string>> TriggerPlacements { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public bool ActivatesOfferGroup { get; set; }

        [MetaMember(7, (MetaMemberFlags)0)]
        public MetaDuration? MaxWaitTimerToPrompt { get; set; }

        public OfferPopupTrigger()
        {
        }

        public OfferPopupTrigger(OfferPopupTriggerId configKey, int maxTriggersPerSession, int maxTriggersTotal, List<PlayerRequirement> triggerRequirements, bool activatesOfferGroup, Dictionary<OfferPopupTriggerPlacementType, List<string>> triggerPlacements, MetaDuration? maxWaitTimerToPrompt)
        {
        }

        public static string ShowMethodEventLastChance { get; }
        public static string ShowMethodEventBackToBack { get; }
        public static string ShowMethodEventLevelReached { get; }
        public static string ShowMethodEventRewardRequiresPurchase { get; }
        public static string ShowMethodBuyMoreEnergy { get; }
        public static string ShowMethodInventory { get; }
        public static string ShowMethodGenericAutomatic { get; }
    }
}