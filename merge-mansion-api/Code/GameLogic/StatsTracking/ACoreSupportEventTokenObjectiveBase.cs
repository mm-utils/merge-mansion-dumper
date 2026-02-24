using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;

namespace Code.GameLogic.StatsTracking
{
    [MetaSerializable]
    [MetaReservedMembers(201, 300)]
    public abstract class ACoreSupportEventTokenObjectiveBase : ASerializedObjectiveBase
    {
        [MetaMember(201, (MetaMemberFlags)0)]
        public CoreSupportEventTokenId CoreSupportTokenEventId { get; set; }
    }
}