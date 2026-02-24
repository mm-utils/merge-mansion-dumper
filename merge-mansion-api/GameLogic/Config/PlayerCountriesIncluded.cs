using Metaplay.Core.Model;
using System;

namespace GameLogic.Config
{
    [MetaSerializableDerived(1072)]
    public class PlayerCountriesIncluded : PlayerPropertyMatcher<string[]>
    {
        public override string DisplayName { get; }
    }
}