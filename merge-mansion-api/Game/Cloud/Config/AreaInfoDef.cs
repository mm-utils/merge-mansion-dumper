using Metaplay.Core.Model;
using GameLogic.Area;
using GameLogic.Config;

namespace Game.Cloud.Config
{
    [MetaSerializableDerived(5)]
    public class AreaInfoDef : ConfigDefinition<AreaId, IAreaInfo>
    {
        public AreaInfoDef(AreaId key)
        {
        }

        private AreaInfoDef()
        {
        }

        public override AreaInfo? GetDef(IMergeMansionGameConfig config)
        {
            if (!config.Areas.TryGetValue(ConfigKey, out AreaInfo area))
                return null;
            return area;
        }
    }
}