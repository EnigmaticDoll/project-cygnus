using Unity.Entities;

public enum MechStateType
{
    Invincible,
    Respawn,
    Stunned,
    PreShot,
    PostShot,
    PreSwap,
    PostSwap,
}

public struct MechStateTimer : IBufferElementData
{
    public MechStateType state;
    public float remainingTime;
    public uint perStateData;
}
