using Metaplay.Core;
using Metaplay.Core.Model;

namespace GameLogic.Area
{
    [MetaSerializable]
    public class AreaId : StringId<AreaId>
    {
        public AreaId()
        {
        }

        public static AreaId MADDIE_MEETS_MANSION;
        public static AreaId COMING_SOON;
    }
}