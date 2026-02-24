namespace Code.GameLogic.GameEvents
{
    public interface IRecordableActionProvider
    {
        ActionRecorder Recorder { get; }
    }
}