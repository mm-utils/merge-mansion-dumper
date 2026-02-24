using Metaplay.Core.Model;
using System;

namespace Code.GameLogic.GameEvents
{
    [MetaSerializable]
    public class ModeTrack
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public string SelectionId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int Value { get; set; }
    }
}