using Unity.Entities;

public enum StageResult
{
    Success,
    PartialSuccess,
    Failed,
    PartialFailed,
    Ongoing
}

public struct StageResultEvaluation : IComponentData
{
    public StageResult result;
}
