using Metaplay.Core.Model;
using System;
using Metaplay.Core;
using GameLogic.Story;
using GameLogic.Config;

namespace GameLogic.Decorations
{
    [MetaSerializable]
    public class DecorationLayerInfo
    {
        [MetaMember(1, (MetaMemberFlags)0)]
        public DecorationLayerId LayerId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        public int RequiredProgress { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        public MetaRef<StoryElementInfo> BeforeAppearDialogue { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        public MetaRef<StoryElementInfo> AfterAppearDialogue { get; set; }

        public DecorationLayerInfo()
        {
        }

        public DecorationLayerInfo(DecorationLayerId layerId, int requiredProgress, MetaRef<StoryElementInfo> beforeAppearDialogue, MetaRef<StoryElementInfo> afterAppearDialogue)
        {
        }

        [MetaMember(5, (MetaMemberFlags)0)]
        public DirectorGroupId DirectorGroupId { get; set; }
    }
}