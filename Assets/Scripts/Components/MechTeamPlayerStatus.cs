using Unity.Entities;

public struct MechTeamPlayerStatus : IComponentData
{
    public uint teamID;
    public uint playerID;
}
