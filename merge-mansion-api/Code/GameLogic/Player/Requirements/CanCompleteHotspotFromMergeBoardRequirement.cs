using Metaplay.Core.Model;
using GameLogic.Player.Requirements;
using GameLogic;

namespace Code.GameLogic.Player.Requirements
{
    [MetaSerializableDerived(67)]
    public class CanCompleteHotspotFromMergeBoardRequirement : PlayerRequirement
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public HotspotId HotspotId { get; set; }
    }
}