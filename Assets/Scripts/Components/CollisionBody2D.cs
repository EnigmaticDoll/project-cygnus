using Unity.Entities;
using UnityEngine;

public enum CollisionBodyType
{
    //Point,
    Circle,
    //Line,
    Square,
}

public struct CollisionBody2D : IComponentData
{
    public CollisionBodyType type;
    public Vector2 size;
    //          x                       y
    // square   width                   height
    // circle   radius
    // points and lines can use circle and square with radius or width 0.
}
