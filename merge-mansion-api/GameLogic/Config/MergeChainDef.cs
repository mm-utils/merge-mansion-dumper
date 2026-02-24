using Metaplay.Core.Model;
using Game.Cloud.Config;
using GameLogic.MergeChains;

namespace GameLogic.Config
{
    [MetaSerializableDerived(3)]
    public class MergeChainDef : ConfigDefinition<MergeChainId, IMergeChainDefinition>
    {
        public override MergeChainDefinition? GetDef(IMergeMansionGameConfig config)
        {
            if (!config.MergeChains.TryGetValue(ConfigKey, out MergeChainDefinition chain))
                return null;
            return chain;
        }
    }
}