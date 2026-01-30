using Metaplay.Core.Model;
using Metaplay.Core;
using System.Runtime.Serialization;

namespace GameLogic.Player.Rewards
{
    [MetaSerializableDerived(25)]
    public class RewardPet : PlayerReward
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        private MetaRef<PetInfo> PetRef { get; set; }

        [IgnoreDataMember]
        public PetId PetId { get; }

        [IgnoreDataMember]
        public PetInfo PetInfo { get; }

        public RewardPet()
        {
        }

        public RewardPet(PetId petId, CurrencySource currencySource)
        {
        }
    }
}