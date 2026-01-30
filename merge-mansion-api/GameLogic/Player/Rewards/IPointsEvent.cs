using Metaplay.Core;
using System;

namespace GameLogic.Player.Rewards
{
    public interface IPointsEvent
    {
        IStringId Id { get; }
    }
}