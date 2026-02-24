using System.Collections.Generic;
using System;

namespace Code.GameLogic.GameEvents
{
    public class ActionRecorder
    {
        private Dictionary<Type, List<IRecordableAction>> Records { get; }
    }
}