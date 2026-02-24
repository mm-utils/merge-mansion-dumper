using Metaplay.Core.Model;
using Metaplay.Core.Config;
using Code.GameLogic.Config;
using Game.Cloud.Config;
using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents.DailyChallenges.Data
{
    [MetaSerializable]
    public class DailyChallengeWeekByPreviousCompletionData : IGameConfigData<DailyChallengesWeekId>, IGameConfigData, IHasGameConfigKey<DailyChallengesWeekId>, IValidatable
    {
        public DailyChallengesWeekId ConfigKey { get; }

        [MetaMember(1, (MetaMemberFlags)0)]
        public ConfigId<DailyChallengesWeekId, DailyChallengesWeekData> PreviousWeekConfigId { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        private List<ValueTuple<float, ConfigId<DailyChallengesWeekId, DailyChallengesWeekData>>> CompletionRatioToNewWeekData { get; set; }
    }
}