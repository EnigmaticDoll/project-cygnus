using Unity.Entities;
using UnityEngine;

public struct ControlCommand : IComponentData
{
    public Vector2 movementDirection;
    public Vector2 aimAt;
    public uint wantedWeaponIdx;
    public bool jump;
    public bool shot;
    public bool dash;
}
