using Metaplay.Core.Model;
using Metaplay.Core.Message;
using System;

namespace Metacore
{
    [MetaSerializableDerived(1)]
    public class LoginRequestMergeMansionPayload : Handshake.ILoginRequestGamePayload
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string AssociationId { get; set; }
    }
}