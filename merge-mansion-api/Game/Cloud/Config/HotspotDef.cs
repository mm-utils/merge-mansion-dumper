using Metaplay.Core.Model;
using GameLogic;
using GameLogic.Config;
using GameLogic.Hotspots;

namespace Game.Cloud.Config
{
    [MetaSerializableDerived(1)]
    public class HotspotDef : ConfigDefinition<HotspotId, IHotspotDefinition>
    {
        public HotspotDef(HotspotId key)
        {
        }

        private HotspotDef()
        {
        }

        public override HotspotDefinition? GetDef(IMergeMansionGameConfig config)
        {
            if (!config.HotspotDefinitions.TryGetValue(ConfigKey, out HotspotDefinition hotspot))
                return null;
            return hotspot;
        }
    }
}