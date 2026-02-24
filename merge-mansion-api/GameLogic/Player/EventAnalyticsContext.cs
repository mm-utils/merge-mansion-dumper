using Metaplay.Core.Model;
using Code.GameLogic.GameEvents;
using System;

namespace GameLogic.Player
{
    [MetaSerializableDerived(3)]
    public class EventAnalyticsContext : AnalyticsContext
    {
        [MetaMember(10, (MetaMemberFlags)0)]
        public EventOfferSetId EventOfferSetId { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        public EventLevelId EventLevelId { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        public string ImpressionId { get; set; }

        public EventAnalyticsContext()
        {
        }

        public EventAnalyticsContext(string context, string target, EventOfferSetId eventOfferSetId, EventLevelId eventLevelId, string impressionId)
        {
        }

        [MetaMember(13, (MetaMemberFlags)0)]
        public string Multiplier { get; set; }
    }
}