using System.Reflection;
using Metaplay.Core.Model;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents
{
    [DefaultMember("Item")]
    [MetaSerializable]
    public class BuilderEventModeData
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public List<ModeTrack> ModeTracks { get; set; }
        public int Item { get; set; }
    }
}