using Unity.Entities;
using UnityEngine;

public struct RigidBody2D : IComponentData
{
    // kinematic only
    public Vector2 coordinates;
    public Vector2 linearVelocity;
    public float rotation;
    public float angularVelocity;
}
