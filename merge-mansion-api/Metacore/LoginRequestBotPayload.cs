using Metaplay.Core.Model;
using Metaplay.Core.Message;
using System;

namespace Metacore
{
    [MetaSerializableDerived(2)]
    public class LoginRequestBotPayload : Handshake.ILoginRequestGamePayload
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string SourcePlayerId { get; set; }
    }
}