using Metaplay.Core.Model;
using Metaplay.Core.Player;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1012)]
    public class PlayerPropertyAssociationIdGroup : TypedPlayerPropertyId<int>
    {
        public override string DisplayName => "Association id modulo group";

        public PlayerPropertyAssociationIdGroup()
        {
        }

        [MetaMember(1, (MetaMemberFlags)0)]
        private int Count { get; set; }
    }
}