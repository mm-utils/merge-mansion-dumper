using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1073)]
    public class PlayerCountriesExcluded : PlayerPropertyMatcher<string[]>
    {
        public override string DisplayName { get; }
    }
}