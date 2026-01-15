using System.Text;
using Metaplay.Core.Config;
using Metaplay.Core.Model;

namespace Metaplay.Core.Serialization
{
    public struct MetaSerializationContext
    {
        public const int DefaultMaxCollectionSize = 0x4000;

        public readonly MetaMemberFlags ExcludeFlags; // 0x0
        public readonly IGameConfigDataResolver Resolver; // 0x8
        public readonly int? LogicVersion; // 0x10
        public readonly StringBuilder DebugStream; // 0x18

        public int MaxStringSize => 0x4000000;
        public int MaxByteArraySize => 0x4000000;
        // CUSTOM: As of version 23.11.01 this property doesn't exist and instead a maxCollectionOverride is passed through the TypeSerializer
        // To keep current code running, this stays here with double the capacity, until further research
        // CUSTOM: As of version 25.01.01 there is at least one instance in the data, where a collection exceeds double the capacity
        // To keep current code running, this is changed to triple the capacity, until further research
        // CUSTOM: As of version 25.10.03 there is at least one instance in the data, where a collection exceeds triple the capacity
        // To keep current code running, this is changed to quadruple the capacity, until further research
        public int MaxCollectionSize => DefaultMaxCollectionSize * 4;

        public MetaSerializationContext(MetaSerializationFlags flags, IGameConfigDataResolver resolver, int? logicVersion, StringBuilder debugStream)
        {
            ExcludeFlags = (MetaMemberFlags)flags;
            Resolver = resolver;
            LogicVersion = logicVersion;
            DebugStream = debugStream;
        }
    }
}
